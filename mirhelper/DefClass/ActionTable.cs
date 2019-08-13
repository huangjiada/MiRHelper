namespace MirHelper
{
	public class ActionTable
	{
		public class Action_Wait
		{
			public class ParameterTable
			{
				public class Parametre_Time
				{
					public const string ParameterName = "Time";

					public const int ParameterTypeId = 100010;
				}
			}

			public const string ActionName = "Wait";

			public const int ActionTypeId = 100;
		}

		public class Action_If
		{
			public class ParameterTable
			{
				public class Parametre_Compare
				{
					public const string ParameterName = "Compare";

					public const int ParameterTypeId = 110010;
				}

				public class Parametre_Index
				{
					public const string ParameterName = "Index";

					public const int ParameterTypeId = 110020;
				}

				public class Parametre_Operator
				{
					public const string ParameterName = "Operator";

					public const int ParameterTypeId = 110030;
				}

				public class Parametre_Value
				{
					public const string ParameterName = "Value";

					public const int ParameterTypeId = 110035;
				}

				public class Parametre_True
				{
					public const string ParameterName = "True";

					public const int ParameterTypeId = 110040;
				}

				public class Parametre_False
				{
					public const string ParameterName = "False";

					public const int ParameterTypeId = 110050;
				}
			}

			public const string ActionName = "If";

			public const int ActionTypeId = 110;
		}

		public class Action_Loop
		{
			public class ParameterTable
			{
				public class Parameter_Iterations
				{
					public const string ParameterName = "Iterations";

					public const int ParameterTypeId = 120010;
				}

				public class Parameter_Content
				{
					public const string ParameterName = "Content";

					public const int ParameterTypeId = 120020;
				}
			}

			public const string ActionName = "Loop";

			public const int ActionTypeId = 120;
		}

		public class Action_While
		{
			public class ParameterTable
			{
				public class Parameter_Compare
				{
					public const string ParameterName = "Compare";

					public const int ParameterTypeId = 130010;
				}

				public class Parameter_Index
				{
					public const string ParameterName = "Index";

					public const int ParameterTypeId = 130020;
				}

				public class Parameter_Operator
				{
					public const string ParameterName = "Operator";

					public const int ParameterTypeId = 130030;
				}

				public class Parameter_Value
				{
					public const string ParameterName = "Value";

					public const int ParameterTypeId = 130040;
				}

				public class Parameter_Content
				{
					public const string ParameterName = "Content";

					public const int ParameterTypeId = 130050;
				}
			}

			public const string ActionName = "While";

			public const int ActionTypeId = 130;
		}

		public class Action_Return
		{
			public const string ActionName = "Return";

			public const int ActionTypeId = 140;
		}

		public class Action_Break
		{
			public const string ActionName = "Break";

			public const int ActionTypeId = 150;
		}

		public class Action_Continue
		{
			public const string ActionName = "Continue";

			public const int ActionTypeId = 160;
		}

		public class Action_MoveToKnownPosition
		{
			public class ParameterTable
			{
				public class Parameter_Position
				{
					public const string ParameterName = "Position";

					public const int ParameterTypeId = 200010;
				}

				public class Parameter_Retries
				{
					public const string ParameterName = "Retries(Blocked Path)";

					public const int ParameterTypeId = 200020;
				}

				public class Parameter_Distancetogoalthreshold
				{
					public const string ParameterName = "Distance to goal threshold";

					public const int ParameterTypeId = 200030;
				}
			}

			public const string ActionName = "Move To Known Position";

			public const int ActionTypeId = 200;
		}

		public class Action_MoveToPostion
		{
			public class Parameter_X
			{
				public const string ParameterName = "X";

				public const int ParameterTypeId = 201010;
			}

			public class Parameter_Y
			{
				public const string ParameterName = "Y";

				public const int ParameterTypeId = 201020;
			}

			public class Parameter_Orientation
			{
				public const string ParameterName = "Orientation";

				public const int ParameterTypeId = 201030;
			}

			public class Parameter_Retries
			{
				public const string ParameterName = "Retries (Blocked Path)";

				public const int ParameterTypeId = 201040;
			}

			public class Parameter_Distancetogoalthreshold
			{
				public const string ParameterName = "Distance to goal threshold";

				public const int ParameterTypeId = 201050;
			}

			public const string ActionName = "Move To Position";

			public const int ActionTypeId = 201;
		}

		public class Action_RelativeMove
		{
			public class Parameter_X
			{
				public const string ParameterName = "X";

				public const int ParameterTypeId = 202010;
			}

			public class Parameter_Y
			{
				public const string ParameterName = "Y";

				public const int ParameterTypeId = 202020;
			}

			public class Parameter_Orientation
			{
				public const string ParameterName = "Orientation";

				public const int ParameterTypeId = 202030;
			}

			public class Parameter_MaxLinearSpeed
			{
				public const string ParameterName = "Max Linear Speed";

				public const int ParameterTypeId = 202040;
			}

			public class Parameter_MaxAngularSpeed
			{
				public const string ParameterName = "Max Angular Speed";

				public const int ParameterTypeId = 202050;
			}

			public class Parameter_CollisionDetection
			{
				public const string ParameterName = "Collision Detection";

				public const int ParameterTypeId = 202060;
			}

			public const string ActionName = "Relative Move";

			public const int ActionTypeId = 202;
		}

		public class Action_Docking
		{
			public class ParameterTable
			{
				public class Parameter_Marker
				{
					public const string ParameterName = "Marker";

					public const int ParameterTypeId = 220010;
				}
			}

			public const string ActionName = "Docking";

			public const int ActionTypeId = 220;
		}

		public class Action_Charging
		{
			public class ParameterTable
			{
				public class Parameter_MinimumTime
				{
					public const string ParameterName = "Minimum Time [Minutes]";

					public const int ParameterTypeId = 230010;
				}

				public class Parameter_MinimumPercentage
				{
					public const string ParameterName = "Minimum Percentage";

					public const int ParameterTypeId = 230020;
				}

				public class Parameter_Chargeuntilnewmissioninqueue
				{
					public const string ParameterName = "Charge until new mission in queue";

					public const int ParameterTypeId = 230030;
				}
			}

			public const string ActionName = "Charging";

			public const int ActionTypeId = 230;
		}

		public class Action_SwitchMap
		{
			public class ParameterTable
			{
				public class Parameter_Map
				{
					public const string ParameterName = "Map";

					public const int ParameterTypeId = 250010;
				}

				public class Parameter_EntryPosition
				{
					public const string ParameterName = "Entry Position";

					public const int ParameterTypeId = 250020;
				}
			}

			public const string ActionName = "Switch Map";

			public const int ActionTypeId = 250;
		}

		public class Action_CreateLogEntry
		{
			public class ParameterTable
			{
				public class Parameter_Description
				{
					public const string ParameterName = "Description";

					public const int ParameterTypeId = 260010;
				}
			}

			public const string ActionName = "Create log entry";

			public const int ActionTypeId = 260;
		}

		public class Action_Playsound
		{
			public class ParameterTable
			{
				public class Parameter_Sound
				{
					public const string ParameterName = "Sound";

					public const int ParameterTypeId = 300010;
				}

				public class Parameter_Duration
				{
					public const string ParameterName = "Duration";

					public const int ParameterTypeId = 300020;
				}

				public class Parameter_Volume
				{
					public const string ParameterName = "Volume";

					public const int ParameterTypeId = 300030;
				}
			}

			public const string ActionName = "Play sound";

			public const int ActionTypeId = 300;
		}

		public class Action_ShowLight
		{
			public class ParameterTable
			{
				public class Parameter_LightEffect
				{
					public const string ParameterName = "Light Effect";

					public const int ParameterTypeId = 301010;
				}

				public class Parameter_Color1
				{
					public const string ParameterName = "Color 1";

					public const int ParameterTypeId = 301020;
				}

				public class Parameter_Color2
				{
					public const string ParameterName = "Color 2";

					public const int ParameterTypeId = 301030;
				}

				public class Parameter_Intensity
				{
					public const string ParameterName = "Intensity";

					public const int ParameterTypeId = 301040;
				}

				public class Parameter_Timeout
				{
					public const string ParameterName = "Timeout";

					public const int ParameterTypeId = 301050;
				}
			}

			public const string ActionName = "Show light";

			public const int ActionTypeId = 301;
		}

		public class Action_WaitForFleet
		{
			public class ParameterTable
			{
				public class Parameter_State
				{
					public const string ParameterName = "State";

					public const int ParameterTypeId = 400010;
				}

				public class Parameter_Value
				{
					public const string ParameterName = "Value";

					public const int ParameterTypeId = 400020;
				}

				public class Parameter_Description
				{
					public const string ParameterName = "Description";

					public const int ParameterTypeId = 400030;
				}
			}

			public const string ActionName = "Wait For Fleet";

			public const int ActionTypeId = 400;
		}

		public class Action_LoadMissionList
		{
			public class ParameterTable
			{
				public class Parameter_MissionList
				{
					public const string ParameterName = "MissionList";

					public const int ParameterTypeId = 500010;
				}
			}

			public const string ActionName = "Load MissionList";

			public const int ActionTypeId = 500;
		}

		public class Action_BluetoothReady
		{
			public class ParameterTable
			{
				public class Parameter_Module
				{
					public const string ParameterName = "Module";

					public const int ParameterTypeId = 600010;
				}

				public class Parameter_Port
				{
					public const string ParameterName = "Port";

					public const int ParameterTypeId = 600020;
				}

				public class Parameter_Operation
				{
					public const string ParameterName = "Operation";

					public const int ParameterTypeId = 600030;
				}

				public class Parameter_Timeout
				{
					public const string ParameterName = "Timeout";

					public const int ParameterTypeId = 600040;
				}
			}

			public const string ActionName = "Bluetooth Ready";

			public const int ActionTypeId = 600;
		}

		public class Action_ElevatorControl
		{
			public class ParameterTable
			{
				public const string ParameterName = "Wait";

				public const int ParameterTypeId = 100;
			}

			public const string ActionName = "Elevator Control";

			public const int ActionTypeId = 601;
		}

		public class Action_OpenDoor
		{
			public class ParameterTable
			{
				public class Parameter_Type
				{
					public const string ParameterName = "Type";

					public const int ParameterTypeId = 602010;
				}

				public class Parameter_Address
				{
					public const string ParameterName = "Address";

					public const int ParameterTypeId = 602020;
				}

				public class Parameter_Message
				{
					public const string ParameterName = "Message";

					public const int ParameterTypeId = 602030;
				}
			}

			public const string ActionName = "Open Door";

			public const int ActionTypeId = 602;
		}

		public class Action_WaitForBluetooth
		{
			public class ParameterTable
			{
				public class Parameter_Module
				{
					public const string ParameterName = "Module";

					public const int ParameterTypeId = 610010;
				}

				public class Parameter_Port
				{
					public const string ParameterName = "Port";

					public const int ParameterTypeId = 610020;
				}

				public class Parameter_Value
				{
					public const string ParameterName = "Value";

					public const int ParameterTypeId = 610030;
				}

				public class Parameter_Timeout
				{
					public const string ParameterName = "Timeout";

					public const int ParameterTypeId = 610040;
				}
			}

			public const string ActionName = "Wait For Bluetooth";

			public const int ActionTypeId = 610;
		}

		public class Action_SetPLCRegister
		{
			public class ParameterTable
			{
				public class Parameter_Register
				{
					public const string ParameterName = "Register";

					public const int ParameterTypeId = 700010;
				}

				public class Parameter_Action
				{
					public const string ParameterName = "Action";

					public const int ParameterTypeId = 700020;
				}

				public class Parameter_Value
				{
					public const string ParameterName = "Value";

					public const int ParameterTypeId = 700030;
				}
			}

			public const string ActionName = "Set PLC Register";

			public const int ActionTypeId = 700;
		}

		public class Action_WaitForPLCRegister
		{
			public class ParameterTable
			{
				public class Parameter_Register
				{
					public const string ParameterName = "Register";

					public const int ParameterTypeId = 701010;
				}

				public class Parameter_Value
				{
					public const string ParameterName = "Value";

					public const int ParameterTypeId = 701020;
				}

				public class Parameter_Timeout
				{
					public const string ParameterName = "Timeout";

					public const int ParameterTypeId = 701030;
				}
			}

			public const string ActionName = "Wait For PLC Register";

			public const int ActionTypeId = 701;
		}

		public class Action_CreatePath
		{
			public class ParameterTable
			{
				public class Parameter_StartPosition
				{
					public const string ParameterName = "Start Position";

					public const int ParameterTypeId = 90010;
				}

				public class Parameter_GoalPosition
				{
					public const string ParameterName = "Goal Position";

					public const int ParameterTypeId = 90020;
				}

				public class Parameter_ViaPosition1
				{
					public const string ParameterName = "Via Position 1";

					public const int ParameterTypeId = 90030;
				}

				public class Parameter_ViaPosition2
				{
					public const string ParameterName = "Via Position 2";

					public const int ParameterTypeId = 90040;
				}

				public class Parameter_ViaPosition3
				{
					public const string ParameterName = "Via Position 3";

					public const int ParameterTypeId = 90050;
				}

				public class Parameter_ViaPosition4
				{
					public const string ParameterName = "Via Position 4";

					public const int ParameterTypeId = 90060;
				}

				public class Parameter_ViaPosition5
				{
					public const string ParameterName = "Via Position 5";

					public const int ParameterTypeId = 90070;
				}

				public class Parameter_ViaPosition6
				{
					public const string ParameterName = "Via Position 6";

					public const int ParameterTypeId = 90080;
				}

				public class Parameter_ViaPosition7
				{
					public const string ParameterName = "Via Position 7";

					public const int ParameterTypeId = 90090;
				}

				public class Parameter_ViaPosition8
				{
					public const string ParameterName = "Via Position 8";

					public const int ParameterTypeId = 900100;
				}

				public class Parameter_ViaPosition9
				{
					public const string ParameterName = "Via Position 9";

					public const int ParameterTypeId = 900110;
				}

				public class Parameter_ViaPosition10
				{
					public const string ParameterName = "Via Position 10";

					public const int ParameterTypeId = 900120;
				}

				public class Parameter_Planningtime
				{
					public const string ParameterName = "Planning time";

					public const int ParameterTypeId = 900130;
				}
			}

			public const string ActionName = "Create Path";

			public const int ActionTypeId = 900;
		}

		public class Action_SendEmail
		{
			public class ParameterTable
			{
				public class Parameter_Recipient
				{
					public const string ParameterName = "Recipient";

					public const int ParameterTypeId = 1000010;
				}

				public class Parameter_Subject
				{
					public const string ParameterName = "Subject";

					public const int ParameterTypeId = 1000020;
				}

				public class Parameter_Message
				{
					public const string ParameterName = "Message";

					public const int ParameterTypeId = 1000030;
				}
			}

			public const string ActionName = "Send E-mail";

			public const int ActionTypeId = 1000;
		}

		public class Action_SendSMS
		{
			public class ParameterTable
			{
				public class Parameter_Recipient
				{
					public const string ParameterName = "Recipient";

					public const int ParameterTypeId = 1001010;
				}

				public class Parameter_Message
				{
					public const string ParameterName = "Message";

					public const int ParameterTypeId = 1001020;
				}
			}

			public const string ActionName = "SendSMS";

			public const int ActionTypeId = 1001;
		}

		public class Action_RouteAction
		{
			public class ParameterTable
			{
				public class Parameter_DefaultWait_Package
				{
					public const string ParameterName = "Default Wait (Package)";

					public const int ParameterTypeId = 200010;
				}

				public class Parameter_DefaultWait_Nopackage
				{
					public const string ParameterName = "Default Wait (No package)";

					public const int ParameterTypeId = 2000020;
				}
			}

			public const string ActionName = "RouteAction";

			public const int ActionTypeId = 2000;
		}

		public class Action_RouteArrivalAction
		{
			public class ParameterTable
			{
				public class Parameter_Wait_Package
				{
					public const string ParameterName = "Wait (Package)";

					public const int ParameterTypeId = 210010;
				}

				public class Parameter_Wait_Nopackage
				{
					public const string ParameterName = "Wait (No package)";

					public const int ParameterTypeId = 2100020;
				}
			}

			public const string ActionName = "Route Arrival Action";

			public const int ActionTypeId = 2100;
		}

		public class Action_TryCatch
		{
			public class ParameterTable
			{
				public class Parameter_Wait_Try
				{
					public const string ParameterName = "Try";

					public const int ParameterTypeId = 300010;
				}

				public class Parameter_Wait_Catch
				{
					public const string ParameterName = "Catch";

					public const int ParameterTypeId = 300020;
				}
			}

			public const string ActionName = "Try/Catch";

			public const int ActionTypeId = 3000;
		}

		public class Action_ThrowError
		{
			public class ParameterTable
			{
				public class Parameter_Wait_Errormessage
				{
					public const string ParameterName = "Error message";

					public const int ParameterTypeId = 3010010;
				}
			}

			public const string ActionName = "Throw Error";

			public const int ActionTypeId = 3010;
		}

		public class Action_PickupTrolley
		{
			public class ParameterTable
			{
				public class Parameter_Wait_Position
				{
					public const string ParameterName = "Position";

					public const int ParameterTypeId = 4000010;
				}

				public class Parameter_Wait_Trolley
				{
					public const string ParameterName = "Trolley";

					public const int ParameterTypeId = 4000020;
				}
			}

			public const string ActionName = "Pickup Trolley";

			public const int ActionTypeId = 4000;
		}

		public class Action_PlaceTrolley
		{
			public class ParameterTable
			{
				public class Parameter_Position
				{
					public const string ParameterName = "Position";

					public const int ParameterTypeId = 4001010;
				}

				public class Parameter_ReleaseTrolley
				{
					public const string ParameterName = "Release Trolley";

					public const int ParameterTypeId = 4001020;
				}

				public class Parameter_Reverseintoplace
				{
					public const string ParameterName = "Reverse into place";

					public const int ParameterTypeId = 4001030;
				}
			}

			public const string ActionName = "Place Trolley";

			public const int ActionTypeId = 4001;
		}

		public class Action_RunURProgram
		{
			public class ParameterTable
			{
				public class Parameter_ProgramName
				{
					public const string ParameterName = "Program Name";

					public const int ParameterTypeId = 5000010;
				}
			}

			public const string ActionName = "Run UR program";

			public const int ActionTypeId = 5000;
		}

		public class Action_PickupShelf
		{
			public class ParameterTable
			{
				public class Parameter_Position
				{
					public const string ParameterName = "Position";

					public const int ParameterTypeId = 6000010;
				}

				public class Parameter_ShelfType
				{
					public const string ParameterName = "Shelf Type";

					public const int ParameterTypeId = 6000020;
				}

				public class Parameter_FinalMovement
				{
					public const string ParameterName = "Final Movement";

					public const int ParameterTypeId = 6000030;
				}
			}

			public const string ActionName = "Pickup Shelf";

			public const int ActionTypeId = 6000;
		}

		public class Action_PlaceShelf
		{
			public class ParameterTable
			{
				public class Parameter_Position
				{
					public const string ParameterName = "Position";

					public const int ParameterTypeId = 6001010;
				}

				public class Parameter_FinalMovement
				{
					public const string ParameterName = "Final Movement";

					public const int ParameterTypeId = 6001020;
				}
			}

			public const string ActionName = "Place Shelf";

			public const int ActionTypeId = 6001;
		}

		public class Action_SetFootprint
		{
			public class ParameterTable
			{
				public class Parameter_Footprint
				{
					public const string ParameterName = "Footprint";

					public const int ParameterTypeId = 7000010;
				}
			}

			public const string ActionName = "Set Footprint";

			public const int ActionTypeId = 7000;
		}

		public class Action_AdjustLocalization
		{
			public class ParameterTable
			{
				public const string ParameterName = "Wait";

				public const int ParameterTypeId = 100;
			}

			public const string ActionName = "Adjust Localization";

			public const int ActionTypeId = 8000;
		}
	}
}
