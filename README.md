To run and test my FreelancerPlatform, the following steps are necessary:
===================================================================================
1. You need to set up project download mysql server, workbench and mysql connect for .net. 

2.After download mysql server and workbench installs mysqldump file to your mysql server local database

 - In this "FreelancePlatform" folder, I have included "freelancer_platform" SQL file.

 - Please import this "freelancer_platform" SQL file into the MySQL Workbench.

3.Add references "MySql.Data" extension to project file.
________________________________________________________________________________________

"How to import self-contained SQL file" into the MySQL Workbench

- Open the MySQL Workbench.
- In the "Server" tab, click on "Data Import".
- Select "Import from Self-Contained File" and locate "201812_Eaint_Myat_Thu_ADI folder" and select "freelancer_platform" SQL file.
- And then, click "New" of Default Target Schema: in order to create schema and type as "freelancer_platform".
- Please go to "Import Progress" tab, and then click "Start Import".
- Then, please refresh SCEMAS under Navigator.
__________________________________________________________________________________________

****Important****

	After importing the "freelancer_platform" SQL file, please change to your own MySQL database, uid and pwd in all necessary files of my program.


// Database connection string
private static readonly string connectionString = "server=localhost;uid=root;pwd=1234;database=freelancer_platform";
 


_________________________________________________________________________________________


=======================Run Project from Visual studio=========================

The followings are testing data for my system.

Clients 
+++++

Username      -	john
Password      -	John@1234

Or 

Clients 
+++++

Username      -	Karen
Password      -	Karen@123


Freelancers
+++++++

Username      -	emt
Password      -	emt@1234

Or

Freelancers
+++++++

Username      -	emery
Password      -	Emery@123

Or

Freelancers
+++++++

Username      -	helen
Password      -	Helen@123

Or

Freelancers
+++++++

Username      -	Peter
Password      -	Peter@123

Or

Freelancers
+++++++

Username      -	jame
Password      -	Jame@123

Or

Freelancers
+++++++

Username      -	Charles
Password      -	Charles123

Or

Freelancers
+++++++

Username      -	Kevin
Password      -	Kevin@123
