# ConnectionOrientedDemo

Copyright (c) 1982, 2014, Oracle.  All rights reserved.

Enter user-name: system
Enter password:
Last Successful login time: Sat Mar 14 2026 13:30:19 +05:30

Connected to:
Oracle Database 12c Enterprise Edition Release 12.1.0.2.0 - 64bit Production
With the Partitioning, OLAP, Advanced Analytics and Real Application Testing options

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
