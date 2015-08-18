@echo Testing your project
@pushd .
@copy CSExercises\bin\debug\*.exe .
@if [%1] NEQ [] "%VS140COMNTOOLS%\..\ide\commonextensions\microsoft\testwindow\vstest.console.exe" ExercisesTest.dll /Logger:trx /Tests:%1
@if [%1] == [] "%VS140COMNTOOLS%\..\ide\commonextensions\microsoft\testwindow\vstest.console.exe" ExercisesTest.dll /Logger:trx
@popd