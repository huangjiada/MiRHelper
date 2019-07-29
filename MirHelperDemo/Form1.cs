using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MirHelper;

namespace MirHelperDemo
{
    public partial class Form1 : Form
    {
        private List<MirMissionAction> mirAction = new List<MirMissionAction>();
        private MirMissionAction action = new MirMissionAction();
        private List<MirMissionParameter> mirParameter = new List<MirMissionParameter>();
        private MirMissionParameter parameter = new MirMissionParameter();
        private List<MirMission> mirMisson = new List<MirMission>();
        private MirMission mission = new MirMission();
        private MirMode mode = new MirMode();


        public Form1()
        {
            InitializeComponent();
           
            GetRegister.Enabled = false;
            DeleteMission.Enabled = false;
            GetMisisonQueueList.Enabled = false;
            DeleteMissionFromQueue.Enabled = false;
            GetRegister.Enabled = false;
            UpdateRegister.Enabled = false;
            GetRegisterList.Enabled = false;
            AddMissionToQueue.Enabled = false;
            GetMissionAction.Enabled = false;
            GetMissionAllActions.Enabled = false;
            CreateActionForMission.Enabled = false;
            DeleteMission.Enabled = false;
            CreateMission.Enabled = false;
            UpdateMission.Enabled = false;
            GetMissionDetail.Enabled = false;
            GetMissionLst.Enabled = false;
            CreateParam.Enabled = false;
            DeleteAction.Enabled = false;
            UpdateAction.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        Mir mir = null;

        private void button1_Click(object sender, EventArgs e)
        {
            MirStatus status = mir.GetMirStatus();
            if (status == null)
            {
                MessageBox.Show(mir.MirError.error_human);
            }
            else
            {
                MessageBox.Show("获取status成功！{0}",status.battery_percentage.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MirMissionAction action = new MirMissionAction();
            action.action_type_id = ActionTable.Action_MoveToPostion.ActionTypeId;
            action.guid = Guid.NewGuid().ToString();
            action.mission_id = "b3e13651-46c7-11e7-b45b-f44d306b7a04";

            MirMissionParameter parameter_x = new MirMissionParameter();
            parameter_x.action_id = action.guid;
            parameter_x.type_id = ActionTable.Action_MoveToPostion.Parameter_X.ParameterTypeId;
            parameter_x.input_name = ActionTable.Action_MoveToPostion.Parameter_X.ParameterName;

            MirMissionParameter parameter_y = new MirMissionParameter();
            parameter_y.action_id = action.guid;
            parameter_y.type_id = ActionTable.Action_MoveToPostion.Parameter_Y.ParameterTypeId;
            parameter_y.input_name = ActionTable.Action_MoveToPostion.Parameter_Y.ParameterName;



            action.priority = 1;
            action.scope_reference = null;
            action.mission = string.Format("/v2.0.0/missions/{0}", action.mission_id);
            action.parameters = "";
            if (mir.CreateAction(action))
            {
                MessageBox.Show("创建Action成功！");
            }
            else
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<MirMissionAction> actionList = mir.GetActionsList();
            if (actionList == null)
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MirMissionAction action = mir.GetActionDetail("mirconst-guid-0000-0001-actlistcont0");
            if (action == null)
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }

        private void UpdateAction_Click(object sender, EventArgs e)
        {
            MirMissionAction action = mir.GetActionDetail("mirconst-guid-0000-0001-actlistcont0");
            action.action_type_id = ActionTable.Action_Continue.ActionTypeId;
            if (mir.UpdateAction(action))
            {
                MessageBox.Show("更新Action成功！");
            }
            else
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }

        private void DeleteAction_Click(object sender, EventArgs e)
        {
            if (mir.DeleteAction("73efb3a6-52da-410d-ad41-5a4a31d2b7ae"))
            {
                MessageBox.Show("删除Action成功！");
            }
            else
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }

        private void CreateParam_Click(object sender, EventArgs e)
        {
            action = mir.GetActionDetail("b3e24a5f-46c7-11e7-b45b-f44d306b7a04");

            MirMissionParameter parameter = new MirMissionParameter();
            parameter.guid = Guid.NewGuid().ToString();
            parameter.name = ActionTable.Action_MoveToPostion.Parameter_X.ParameterName;
            parameter.action_id = action.guid;
            parameter.action = string.Format("/v2.0.0/actions/{0}", action.guid);
            parameter.mission = action.mission;
            parameter.mission_action = string.Format("/v2.0.0/missions/{0}/actions/{1}", action.mission_id, action.guid);
            parameter.is_input = false;
            parameter.type_id = ActionTable.Action_MoveToPostion.Parameter_X.ParameterTypeId;

            if (mir.CreateParameter(parameter))
            {
                MessageBox.Show("创建parameter成功！");
            }
            else
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }


        private void GetMissionLst_Click(object sender, EventArgs e)
        {
            List<MirMission> missionList = mir.GetMissionList();
            if (parameter == null)
            {
                MessageBox.Show(mir.MirError.error_human);
            }
            else
            {
                MessageBox.Show("得到列表成功");
            }
        }

        private void GetMissionDetail_Click(object sender, EventArgs e)
        {
            MirMission mission = mir.GetMissionDetail("mirconst-guid-0000-0001-actionlist00");
            if (mission == null)
            {
                MessageBox.Show("获取Mission详细信息成功！");
            }
            else
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }

        private void UpdateMission_Click(object sender, EventArgs e)
        {
            MirMission mission = mir.GetMissionDetail("mirconst-guid-0000-0001-actionlist00");
            if (mission != null)
            {
                mission.name = "Taxi";
                if (mir.UpdateMission(mission))
                {
                    MessageBox.Show("更新mission成功！");
                }
                else
                {
                    MessageBox.Show(mir.MirError.error_human);
                }
            }
        }

        private void CreateMission_Click(object sender, EventArgs e)
        {
            mission.guid = Guid.NewGuid().ToString();
            mission.name = "createTest";
            mir.CreateMission(mission);
        }

        private void DeleteMission_Click(object sender, EventArgs e)
        {
            if (mir.DeleteMission("0b8d7896-00a7-4d52-bd9b-5d26ac3f2b89"))
            {
                MessageBox.Show("删除mission成功！");
            }
            else
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }

        private void CreateActionForMission_Click(object sender, EventArgs e)
        {
            MirMissionAction action = new MirMissionAction();
            action.guid = Guid.NewGuid().ToString();
            action.mission_id = "75419c79-46cf-11e7-ad31-b8aeed759236";
            action.action_type_id = ActionTable.Action_Continue.ActionTypeId;
            mir.CreateActionForMission(action, "75419c79-46cf-11e7-ad31-b8aeed759236");
        }

        private void GetMissionAllActions_Click(object sender, EventArgs e)
        {
            List<MirMissionAction> mirAction = mir.GetMissionAllActions("mirconst-guid-0000-0001-actionlist00");
            if (mirAction != null)
            {
                MessageBox.Show("获取Mission中所有的Action列表成功！");
            }
            else
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }

        private void GetMissionAction_Click(object sender, EventArgs e)
        {
            MirMissionAction action = mir.GetMissionAction("mirconst-guid-0000-0001-actionlist00", "mirconst-guid-0000-0001-actlistcont0");
            if (action == null)
            {
                MessageBox.Show("获取某个Mission的Action信息成功！");
            }
            else
            {
                MessageBox.Show(mir.MirError.error_human);
            }
        }


        private void AddMissionToQueue_Click(object sender, EventArgs e)
        {
            MirMission mission = mir.GetMissionDetail("f2ed0b78-4096-11e7-9e95-f44d306b7a04");
            if (mission != null)
            {
                List<MirMissionParameter> mirparameters = mir.GetParameterListFromMission("f2ed0b78-4096-11e7-9e95-f44d306b7a04");
                if (mirparameters != null)
                {
                    MirQueueMission queueMission = new MirQueueMission();
                    queueMission.mission = mission.guid;
                    queueMission.parameters = new List<MirQueueParameter>();
                    foreach (MirMissionParameter parameter in mirparameters)
                    {
                        MirQueueParameter queueparamter = new MirQueueParameter();
                        queueparamter.input_name = parameter.input_name;
                        queueparamter.value = parameter.value;
                        queueMission.parameters.Add(queueparamter);
                    }

                    if (mir.AddMissionToQueue(queueMission))
                    { MessageBox.Show("将mission添加到Mission Queue中成功！"); }
                    else
                    { MessageBox.Show(mir.MirError.error_code); }
                }
                else
                {
                    MessageBox.Show(mir.MirError.error_code);
                }
            }
            else
            {
                MessageBox.Show(mir.MirError.error_code);
            }

        }

        private void GetRegisterList_Click(object sender, EventArgs e)
        {
            List<MirRegister> res = mir.GetMirRegisters();
            if (res == null)
            {
                MessageBox.Show(mir.MirError.error_code);
            }
            else
            {
                MessageBox.Show("generate success");
            }
        }

        private void UpdateRegister_Click(object sender, EventArgs e)
        {
            MirRegister res = new MirRegister();
            res.id = Int32.Parse(this.PLCID.Text);
            res.value = Int32.Parse(this.PLCvalue.Text);

            if (!mir.UpdateMirRegister(res))
            {
                MessageBox.Show(mir.MirError.error_code);
            }
        }

        private void GetRegister_Click(object sender, EventArgs e)
        {
            MirRegister res = mir.GetMirRegisterById(1);
            if (res == null)
            {
                MessageBox.Show(mir.MirError.error_code);
            }
            else
            {
                MessageBox.Show(string.Format("ID:{0},value:{1}",res.id,res.value));
            }
        }

        private void DeleteMissionFromQueue_Click(object sender, EventArgs e)
        {
            List<MirMissionQueueId> misisons = mir.GetMissionQueueList(5);
            if (misisons == null)
            {
                MessageBox.Show(mir.MirError.error_code);
            }
            else
            {
                MirMissionQueueId mission = misisons.Find(a => a.mission_id == "f2ed0b78-4096-11e7-9e95-f44d306b7a04");
                if (mission != null && mir.DeleteMissionFromQueue(mission.id))
                {
                    MessageBox.Show("将Mission从Queue中删除成功！");
                }
                else
                {
                    MessageBox.Show(mir.MirError.error_code);
                }
            }

        }

        private void GetMisisonQueueList_Click(object sender, EventArgs e)
        {
            List<MirMissionQueueId> misisons = mir.GetMissionQueueList(5);
            if (misisons == null)
            {
                MessageBox.Show(mir.MirError.error_code);
            }
            else
            {
                MessageBox.Show("获取Mission Queue中misison队列成功！");
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (this.IPtextbox.Text != null && this.usertextBox.Text != null && this.passwordtextBox.Text != null)
            {
                GetRegister.Enabled = true;
                DeleteMission.Enabled = true;
                GetMisisonQueueList.Enabled = true;
                DeleteMissionFromQueue.Enabled = true;
                GetRegister.Enabled = true;
                UpdateRegister.Enabled = true;
                GetRegisterList.Enabled = true;
                AddMissionToQueue.Enabled = true;
                GetMissionAction.Enabled = true;
                GetMissionAllActions.Enabled = true;
                CreateActionForMission.Enabled = true;
                DeleteMission.Enabled = true;
                CreateMission.Enabled = true;
                UpdateMission.Enabled = true;
                GetMissionDetail.Enabled = true;
                GetMissionLst.Enabled = true;
                CreateParam.Enabled = true;
                DeleteAction.Enabled = true;
                UpdateAction.Enabled = true;
                button4.Enabled = true;
                button3.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = true;

                mir = null;
                mir = new Mir("mir100", this.IPtextbox.Text, this.usertextBox.Text, this.passwordtextBox.Text);

            }
            else
            {
                MessageBox.Show("输入缺失");
            }
        }

    }
}
