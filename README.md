# ConnectionOrientedDemo

Copyright (c) 1982, 2014, Oracle.  All rights reserved.

Enter user-name: system
Enter password:
Last Successful login time: Sat Mar 14 2026 13:30:19 +05:30

Connected to:
Oracle Database 12c Enterprise Edition Release 12.1.0.2.0 - 64bit Production
With the Partitioning, OLAP, Advanced Analytics and Real Application Testing options
----------------------------------------------------------------------------------------------------
SQL> CREATE TABLE Students (
  2      RollNo NUMBER PRIMARY KEY,
  3      Name   VARCHAR2(50),
  4      Course VARCHAR2(50)
  5  );

Table created.

SQL> INSERT INTO Students VALUES (1, 'Amit', 'MCA');

1 row created.

SQL> INSERT INTO Students VALUES (2, 'Priya', 'MCA');

1 row created.

SQL> INSERT INTO Students VALUES (3, 'Rahul', 'MCA');

1 row created.

SQL> INSERT INTO Students VALUES (4, 'Sneha', 'MCA');

1 row created.

SQL> COMMIT;

Commit complete.
----------------------------------------------------------------------------------------
INSERT INTO Students VALUES (5, 'Shahazad', 'MCA');

Commit;
-----------------------------------------------------------------------------------

SQL> UPDATE Students
  2  SET Name = 'Radhe'
  3  WHERE RollNo = 4;

1 row updated.

SQL> COMMIT;

Commit complete.

SQL> SELECT * FROM Students;

    ROLLNO NAME
---------- --------------------------------------------------
COURSE
--------------------------------------------------
         1 Amit
MCA

         2 Priya
MCA

         3 Rahul
MCA


    ROLLNO NAME
---------- --------------------------------------------------
COURSE
--------------------------------------------------
         4 Radhe
MCA

         5 Shahazad
MCA
---------------------------------------------
SELECT table_name FROM user_tables;

DESC Students;

SELECT * FROM Students;






