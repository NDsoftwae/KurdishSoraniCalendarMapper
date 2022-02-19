# KurdishSoraniCalendarMapper
This library maps Gregorian Date to Kurdish Sorani Date.

# Installing 
- Using Package manager : Install-Package KurdishCalendar -Version 1.0.1
- Using Dotnet CLI : dotnet add package KurdishCalendar --version 1.0.1
- Through Package Reference: "<PackageReference Include="KurdishCalendar" Version="1.0.1" />"
- Using Packet CLI : paket add KurdishCalendar --version 1.0.1


# Using. 
To map the Gregorian Date to Kurdish date, this library have a number of extension methods, which can return KuridshDateTime Object or String.
- Importing the package : Using KurdishCalendar;
- create on object of DateTime which referse to any Gregorian Date:</br>
                </v> <h5>DateTime __today = DateTime.Today;</h5>
                </v> <h5>KuridshDateTime __KurdishDate = __today.toKurdish();</h5></br>
