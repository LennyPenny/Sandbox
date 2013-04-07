CreateConVar("lenny_bunnyhop", 1)

function Bunnyhop()
	if GetConVarNumber("lenny_bunnyhop") == 1 then
	 	if input.IsKeyDown(KEY_SPACE) then
	 		if LocalPlayer():IsOnGround() then
	 			RunConsoleCommand("+jump")
	 			timer.Create("Bhop", 0, 0.01, function()
	 		 	RunConsoleCommand("-jump")
	 		 	
	 		 	end)
	 		end
	 	end
	end
end

hook.Add("Think", "Bunnyhop", Bunnyhop )