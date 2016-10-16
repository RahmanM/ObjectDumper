In the past I had to dump an object to string for Debuging or Auditing purposes.

This is a simple class that dumps any object to a Xml representation of it that can be logged
or saved etc.

Usage is simple:

```C#

// Initialise the object
var emp = new Employee(){
				FirstName = "Rahman",
				LastName = "Mahmoodi",
				DateOfBirth = DateTime.Now
			};
			
// Call the dumper and get string
var str = ObjectDumper<Employee>.Dump(emp);

```

Result is:

```Xml

<?xml version="1.0" encoding="utf-16"?>
<Employee>
  <FirstName>Rahman</FirstName>
  <LastName>Mahmoodi</LastName>
  <DateOfBirth>2016-10-16T14:16:48.7354111+11:00</DateOfBirth>
</Employee>


```