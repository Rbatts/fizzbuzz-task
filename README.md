# -Calculator-

## header 2

### header 3
```c#
        [HttpPost("CreateAbsenceRequest")]
        public async Task<AbsenceRequest> CreateAbsenceRequest([FromBody]AbsenceRequest absenceRequest)
        {
            long id = await this.AbsenceRequestCommandAgent.Create(absenceRequest).ConfigureAwait(false);

            List<Task<long>> saveChildrenTasks = new List<Task<long>>();
            foreach (var requestDate in absenceRequest.AbsenceRequestDates)
            {
                requestDate.AbsenceRequestId = id;
                saveChildrenTasks.Add(this.RequestDateCommandAgent.Create(requestDate));
            }

            await Task.WhenAll(saveChildrenTasks).ConfigureAwait(false);
            return absenceRequest;
        }
```
1. Ordered lists are fun
2. The numbers go up
3. With every point

* Unordered lists are also fun
* not as much though
