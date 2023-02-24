# Known Issues


2023-02-24 ueforth 7.0.7.9 on MacOS

- The file mode names in posix/posix.fs do not match on Mac OS, e.g. `O_CREAT` has the valie of 512 on MacOS.

- As a consequence the save-test fails. 

- restore test leads to a dictionary where no word is found and also numbers are no longer detected

