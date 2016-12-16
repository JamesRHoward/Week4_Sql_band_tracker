# _Band Tracker_

#### _Application using C#, SQL, Nancy, Razor, and Xunit that tracks the venues a band has played at and what bands have played at a particular venue, 12/16/16_

#### By _**James R. Howard**_

## Description

_This application uses SQL databases to save information on bands and venues. The saved bands or venues can be assigned to one another, for instance; The band Kiss has played at the Moda Center. This joins the information from the different tables. This application uses many to many relationships ie(a band can have played at many venues, and a venue can have many bands that have played there). The application also allows the user to update venue and band information as well as delete it, giving it full CRUD functionality._

## Setup/Installation Requirements

* _Windows OS_
* _Clone file from GitHub.com_
* _Open SQL_
* _Copy the band_tracker.sql file(found in project folder)_
* _Click on New Query(Ctrl + N) in SQL_
* _Paste the scripts and hit Execute(F5)_
* _Open Windows PowerShell_
* _Use command >dnu restore_
* _Use command >dnx kestrel_
* _Open a Chrome browser_
* _Go To http://localhost:5004_

__

## Known Bugs

_There are no known bugs at this point in time._

## Support and contact details

_If you have any questions or concerns please contact me at jrh682@gmail.com_

## Technologies Used

_This application uses_
* _HTML_
* _C#_
* _"Microsoft.AspNet.Server.Kestrel": "1.0.0-*"_
* _"Microsoft.AspNet.Owin": "1.0.0-*"_
* _"Nancy": "1.3.0"_
* _"Nancy.ViewEngines.Razor": "1.3.0_
* _"xunit": "2.1.0"_
* _"xunit.runner.dnx": "2.1.0-rc1-*"_
* _SQL_

### License

*The MIT License (MIT)
Copyright (c) <2016> <James R. Howard>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.*

Copyright (c) 2016 **_James R. Howard Student at EPICODUS_**
