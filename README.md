## Demo Day Attendee Recorder

### Specs:
> This quick project was built to collect attendee information from those persons who visit me during my NSS "Demo Day" presentation.
> Instead of having to write down their information, attendees can fill out a quick on-line form and submit the data with a picture taken by the input tablet.  Users also have the option to not submit a picture.  


### Main Technologies Used:
> 1. [.NET Core 1.1 (in Linux)](https://www.microsoft.com/net/download/core)
> 1. [MySQL Server 5.7.17](https://dev.mysql.com/downloads/mysql/)   
> 1. [Semantic-UI 2.2](http://semantic-ui.com/)
> 1. HTML5 with Razor (part of the .NET Core Package)
> 1. [IPCam](https://play.google.com/store/apps/details?id=com.pas.webcam) Needed to supply the camera for taking users pictures  

### Final Result:
##### A basic user form that collects an attendee's name, email and company/organization along with their photo.

> With this a user can:  
> 1. Submit their name, email address and company/organization  
> 2. Submit a picture along with the above information  

### How to run:
```
1. A device using the IPCam software package is needed to supply the camera needed to take the photo at form entry
2. You will need access to a MySQL server and an account that can create databases  
2. Install .NET Core 1.1 package
3. Download/Clone this repo
4. At the base directory run `dotnet restore` to restore the required libraries  
5. At the base directory run `dotnet run` to run the application (port 5001 is the default for this project)
```
### Note:
> A private class is used to hold both the MySQL server property and the IP address of the tablet containing the webcamera.  
> You can make one using the scaffolding below:
```
public class PrivateParameters
    {
        public static string MySQLParameterString { get; } = @"server={ server IP };port= { port # };database={ db name here };uid={ user name here };pwd={ password here };";  // No {} in the server, port, database, uid or pwd names
        public static string cameraIP { get; } = "0.0.0.0";
    } 
```

### Specs By:
[Bernie Anderson](https://github.com/bernardanderson) 

### Contributors:
[Bernie Anderson](https://github.com/bernardanderson) 
