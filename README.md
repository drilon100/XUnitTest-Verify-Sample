The repository utilizes the Verify snapshot approach to test HTML extensions and SOAP XML files.

Using Verify snapshot, the repository ensures that the HTML extensions and SOAP XML files do not change unexpectedly as the codebase is updated. This is achieved by comparing the current version of the codebase against a previously saved snapshot of the expected output. If there are any differences between the two, the test will fail and alert the developers that a change has occurred.
