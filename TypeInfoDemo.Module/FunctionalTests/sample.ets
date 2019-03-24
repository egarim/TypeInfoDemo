;#DropDB TypeInfoDemoEasyTest

#Application TypeInfoDemo.Win
#Application TypeInfoDemo.Web
#IfDef TypeInfoDemo.Win

*Action About...
 
*Action OK

#EndIf

#IfDef TypeInfoDemo.Web
!Action Navigation(My Details)
#EndIf
