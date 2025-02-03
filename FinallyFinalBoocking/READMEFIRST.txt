Short instructions how to set right settings and use application properly

Go to the Fileelper.cs and paste in the line 16 (under this code)


Path.Combine(@"C:\Users\Orest\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB", fileName),
Path.Combine(@"C:\Users\qwerd\Source\Repos\FinallyFinalBooking\FinallyFinalBoocking\DumbStaffDB", fileName))


and paste similar code but with your file directory(you can copy it by pressing on the DumbStaffDB.txt and choose copy fool path)
(if downoaded properly only name after users like Orest oer qwerd will be different)
like this Path.Combine(@"YOUR_FILE_DIRECTORY", filename)

That should allow you to navigate freely throught the application and have greate expirience


P.S. Sorry for inconveniences, but we didn't manage to fix one path(it just stop workink in another way), 
and you also need to chage file directory on the Cover.cs in the line 111 to your path