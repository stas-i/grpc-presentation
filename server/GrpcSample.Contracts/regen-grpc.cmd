@rem enter this directory
cd /d %~dp0

SET GRPC_TOOLS=%USERPROFILE%\.nuget\packages\Grpc.Tools\1.6.1\tools\windows_x64\
SET PROTOBUF_TOOLS=%USERPROFILE%\.nuget\packages\Google.Protobuf.Tools\3.4.0\tools

SET IN=Proto
SET OUTPUT=Proto

FOR /f "tokens=*" %%G IN ('dir %IN% /b ^| findstr proto') DO %GRPC_TOOLS%\protoc -I.\%IN%\;%PROTOBUF_TOOLS% --csharp_out %OUTPUT% %IN%/%%G --grpc_out %OUTPUT% --plugin=protoc-gen-grpc=%GRPC_TOOLS%\grpc_csharp_plugin.exe

pause
