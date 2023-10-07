# Developer-Defined Accelerations in Continuous Integration: A Detection Approach and Catalog of Patterns
## Replication
Our database is very large (over 1TB uncompressed). Hence, our database is available on request. This repository contains the inspection results.

### RQ1
#### Manual Inspection
The samples and inspection results are in the `rq1_inspection.xlsx`` file. The file `rq1_inspection_agreed.csv` is for computer processing (evaluating performance and counting agreement etc.).

#### Evaluation
First, download the files in `src` folder. Then, install [.NET SDK](https://dotnet.microsoft.com/en-us/download) (.NET 7.0 is preferred).

Locate to `src/BuildAcceleration/BuildAcceleration` folder, run `dotnet run -- -h`.

- To calculate clusters and ratios, run `dotnet run -- cluster` (this requires database, which is available on request).
- To detect accelerated jobs by rules, run `dotnet run -- detect` (this also requires database).

However, the results of clustering `KMeansCluster.csv` and `KMeansClusterRatio.csv` are placed in the replication folder. The results of detection `ruled_detection.csv` is also placed.

### RQ2 
#### Detection
To detect accelerated jobs, run `dotnet run -- cluster --all` and `dotnet run -- detect`. This produces `k-means_all.csv` and `ruled_detection.csv`. Then manually (using Excel) select detected jobs based on the threshold.

#### Manual Inspection
The inspection results are in the `rq2_classification.xlsx` file. The file `rq2_Final Labels.csv` is for computer processing.

#### Processing
As described in the paper, the labels are full sentences. To convert it to labels, first, put `rq2_Final Labels.csv` to `Desktop/build_accel/Final Labels.csv`. Then, run `dotnet run -- count-categories`. The results will appear in `Desktop/build_accel` folder. Note that we did further modification to the category and pattern names, so the output does not fully align with what is presented in the paper.