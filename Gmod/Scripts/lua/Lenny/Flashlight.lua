CreateConVar("lenny_flashlight", 0)

function Flashspam()
	if GetConVarNumber("lenny_flashlight") == 1 then
		if input.IsKeyDown(KEY_H) then
			RunConsoleCommand("impulse", "100")
			timer.Create("Flight", 0, 0.01, function()
				RunConsoleCommand("impulse", "100")
				
			end)
		else
			timer.Destroy("Flight")
		end
	end
end

hook.Add("Think", "Flspam", Flashspam )