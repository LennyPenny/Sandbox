

-- DarkRP NameChanger

local names = {        -- Simply add/remove/modify this list if you want more/less/other names
"Peter Maffai", 
"Michael Jackson", 
"Thomas McGee", 
"Clint Westwood", 
"Jonathan Bumble", 
"Tom Oblus", 
"Lennart Hupple", 
"Harry Kuss", 
"Willhelm Dumble", 
"Christopher Game", 
"Paul MacCardnay", 
"Elton Yon",
"Ashton Kitingson",
"Mick Momnay", 
"Dirk Dauer", 
"Ian Meow", 
"Ronald McGayben", 
"Gabe Oldwell", 
"Domnik Klein", 
"Lennerd Bearenhart", 
"Test Test Test",
"Test123 Test123",

}
local counter = 1

concommand.Add( "rp_namechange" , function()
LocalPlayer():ConCommand("say /rpname " ..names[counter].. "")
counter = counter + 1

if counter > table.getn(names) then
	counter = 1
end

end)

