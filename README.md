# Developer-Defined Accelerations in Continuous Integration: A Detection Approach and Taxonomy
## Replication
Our database is very large (over 1GB uncompressed). Hence, our database is available on request. This repository contains the inspection results.

### RQ1 Manual Inspection
The inspection results are in the `rq1_inspection.xlsx`` file. The file `rq1_inspection_agreed.csv` is for computer processing (evaluating performance and counting agreement etc.).

### RQ2 Manual Inspection
The inspection results are in the `rq2_classification.xlsx` file. The file `rq2_Final Labels.csv` is for computer processing.

### Detection
First, download the files in `src` folder. Then, install [.NET SDK](https://dotnet.microsoft.com/en-us/download) (.NET 7.0 is preferred).

Locate to `src/BuildAcceleration/BuildAcceleration` folder, run `dotnet run -- -h`.

- To calculate clusters and ratios, run `dotnet run -- cluster` (this requires database, which is available on request).
- To detect accelerated jobs by rules, run `dotnet run -- detect` (this also requires database).
