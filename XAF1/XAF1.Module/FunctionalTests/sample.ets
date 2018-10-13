;#DropDB XAF1EasyTest

#Application XAF1.Win
#Application XAF1.Web
#IfDef XAF1.Win

*Action About...
 
*Action OK

#EndIf

#IfDef XAF1.Web
!Action Navigation(My Details)
#EndIf
