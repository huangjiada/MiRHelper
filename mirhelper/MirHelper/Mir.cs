using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace MirHelper
{
    /// <summary>
    /// Mir API 2.1.0 自行版本上升
    /// 版本上升后先更改定义类，再修改方法函数
    /// </summary>
	public class Mir
	{
        private JavaScriptSerializer js = new JavaScriptSerializer();
		private static APIHelper apiHelper;

		public string name
		{
			get;
			set;
		}

		public string ip
		{
			get;
			set;
		}

		public MirErrorEntity MirError
		{
			get;
			set;
		}

		public Mir(string name, string ip,string userid,string userpassword)
		{
            this.name = name;
            this.ip = ip;
			MirError = new MirErrorEntity();
			apiHelper = new APIHelper(ip,userid,userpassword);
		}

		public GetStatus GetMirStatus()
		{
			string text = apiHelper.ExecuteGet("status");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<GetStatus>(text);
		}

        public bool CreateAction(MirMissionAction action)
		{

			string text = apiHelper.ExecutePost("actions", js.Serialize(action));
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public List<MirMissionAction> GetActionsList()
		{

			string text = apiHelper.ExecuteGet("actions");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<List<MirMissionAction>>(text);
		}

		public MirMissionAction GetActionDetail(string actionid)
		{

			string text = apiHelper.ExecuteGet("actions/" + actionid);
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<MirMissionAction>(text);
		}

		public bool UpdateAction(MirMissionAction action)
		{

			string text = apiHelper.ExecutePut("actions/" + action.guid, js.Serialize(action));
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public bool DeleteAction(string actionid)
		{

			string text = apiHelper.ExecuteDelete("actions/" + actionid);
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public bool CreateParameter(MirMissionParameter parameter)
		{

			string text = apiHelper.ExecutePost($"missions/{parameter.mission}/actions/{parameter.mission_action}/parameters", js.Serialize(parameter));
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}


        public List<MirMissionParameter> GetParameterListFromMission(string missionid)
		{
			string text = apiHelper.ExecuteGet($"/missions/{missionid}/inputs");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<List<MirMissionParameter>>(text);
		}

		public bool CreateMission(MirMission mission)
		{

			string text = apiHelper.ExecutePost("missions", js.Serialize(mission));
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public List<MirMission> GetMissionList()
		{

			string text = apiHelper.ExecuteGet("missions");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<List<MirMission>>(text);
		}

		public MirMission GetMissionDetail(string mission_id)
		{

			string text = apiHelper.ExecuteGet($"missions/{mission_id}");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<MirMission>(text);
		}

		public bool UpdateMission(MirMission mission)
		{

			string text = apiHelper.ExecutePut("missions/" + mission.guid, js.Serialize(mission));
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public bool DeleteMission(string missionid)
		{

			string text = apiHelper.ExecuteDelete("missions/" + missionid);
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public bool CreateActionForMission(MirMissionAction action, string missionid)
		{

			string text = apiHelper.ExecutePost($"missions/{missionid}/actions", js.Serialize(action));
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public List<MirMissionAction> GetMissionAllActions(string missionid)
		{

			string text = apiHelper.ExecuteGet($"missions/{missionid}/actions");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<List<MirMissionAction>>(text);
		}

		public MirMissionAction GetMissionAction(string missionid, string actionid)
		{

			string text = apiHelper.ExecuteGet($"missions/{missionid}/actions/{actionid}");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<MirMissionAction>(text);
		}

		public List<MirMissionParameter> GetMissionAllParameters(string missionid)
		{

			string text = apiHelper.ExecuteGet($"missions/{missionid}/inputs");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<List<MirMissionParameter>>(text);
		}
        

        public bool AddMissionToQueue(MirQueueMission mission)
		{

			string text = apiHelper.ExecutePost("mission_queue", js.Serialize(mission));
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public bool DeleteMissionFromQueue(int missionQueueid)
		{

			string text = apiHelper.ExecuteDelete("mission_queue/" + missionQueueid);
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

        /// <summary>
        /// 反向获得任务列表里的指定个数的任务
        /// </summary>
        /// <param name="topCount"></param>
        /// <returns></returns>
        public List<MirMissionQueueId> GetMissionQueueList(int topCount)
		{
			if (topCount <= 0)
			{
				MirError.error_code = "500";
				MirError.error_human = "Invalid parameter.topCount below zero";
				return null;
			}
			string text = apiHelper.ExecuteGet("mission_queue");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			List<GetMission_queues> list = js.Deserialize<List<GetMission_queues>>(text);
			List<MirMissionQueueId> list2 = new List<MirMissionQueueId>();
			topCount = ((list.Count >= topCount) ? topCount : list.Count);
			for (int i = 0; i < topCount; i++)
			{
				text = apiHelper.ExecuteGet("mission_queue/" + list[i].id);
				if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
				{
					MirError = js.Deserialize<MirErrorEntity>(text);
					return null;
				}
				list2.Add(js.Deserialize<MirMissionQueueId>(text));
			}
			return list2;
		}

		public List<MirRegister> GetMirRegisters()
		{

			string text = apiHelper.ExecuteGet("registers");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<List<MirRegister>>(text);
		}

		public bool UpdateMirRegister(MirRegister register)
		{

			string text = apiHelper.ExecutePut($"registers/{register.id}", js.Serialize(register));
			if (text.Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return false;
			}
			return true;
		}

		public MirRegister GetMirRegisterById(int register_id)
		{
			string text = apiHelper.ExecuteGet($"registers/{register_id}");
			if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
			{
				MirError = js.Deserialize<MirErrorEntity>(text);
				return null;
			}
			return js.Deserialize<MirRegister>(text);
		}

        #region 等待要写的函数
        //public abstract  PutMirStatus();//改变MiR的status属性，并返回最新的status
        //GetPositions
        //PostPositions
        //GetPosition
        //PostPosition
        //mobus;开启modebus支持

        //hook;//开启钩爪的支持 


        /// <summary>
        /// 将小车返回的MissionQueue信息由客户端计算，剔除执行完成以及放弃的任务
        /// </summary>
        /// <returns></returns>
        //public List<MirMissionQueueId> GetExecuteMissionQueue()
        //{
        //    string text = apiHelper.ExecuteGet("mission_queue");
        //    if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
        //    {
        //        MirError = js.Deserialize<MirErrorEntity>(text);
        //        return null;
        //    }
        //    List<GetMission_queues> list = js.Deserialize<List<GetMission_queues>>(text);
        //    List<MirMissionQueueId> list2 = new List<MirMissionQueueId>();
        //    foreach (var item in list2)
        //    {
        //        item
        //    }
        //    topCount = ((list.Count >= topCount) ? topCount : list.Count);
        //    for (int i = 0; i < topCount; i++)
        //    {
        //        text = apiHelper.ExecuteGet("mission_queue/" + list[i].id);
        //        if (string.IsNullOrEmpty(text) || text.ToString().Contains("error_code"))
        //        {
        //            MirError = js.Deserialize<MirErrorEntity>(text);
        //            return null;
        //        }
        //        list2.Add(js.Deserialize<MirMissionQueueId>(text));
        //    }
        //    return list2;
        //}
        #endregion
    }
}
