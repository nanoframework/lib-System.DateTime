1. Updating the Nuget package(s)

After updating the Nuget packages, the project file (nfproj extension) has to be manually edited too in order to update the path for the new package for all <NFMDP_PE_LoadHints> tags.


2. Generating/updating stubs

The generated stubs for this class library have to be placed in two different places in the nf-interpreter tree.

1) The part that is the subset of the Base Class Library (mscorlib) goes into the 'src\CLR\System.DateTime' folder.
2) The part that is specific to the target implementation has to go into the specific folder for each target. For ChibiOS this would be 'targets\CMSIS-OS\ChibiOS\nanoCLR\System.DateTime'
