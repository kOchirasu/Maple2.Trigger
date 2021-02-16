using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000555_bf {
    public static class _main {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateDefaultSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting : TriggerState {
            internal StateDefaultSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8100, 8101, 8102, 8103, 8104, 8200, 8201, 8202, 8203, 8300, 8301, 8302, 8303, 8304, 8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412, 8413, 8414, 8415, 8416, 8417, 8418, 8419, 8420, 8421, 8422, 8423, 8424, 8425, 8426}, arg2: false);
                context.SetEffect(arg1: new[] {8500, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8511, 8512, 8513, 8514, 8515, 8516, 8517}, arg2: false);
                context.SetEffect(arg1: new[] {8600, 8601, 8602, 8801, 8802, 8803, 8804, 8805}, arg2: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {4012, 4013, 4014, 4015, 4001, 4002, 4003, 4004}, arg2: true);
                context.SetInteractObject(arg1: new[] {10003145}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701}, arg2: 0)) {
                    return new StateStage1_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_시작 : TriggerState {
            internal StateStage1_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2900)) {
                    return new StateStage1_추가SpawnWait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_추가SpawnWait01 : TriggerState {
            internal StateStage1_추가SpawnWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__37$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") <= 6) {
                    return new StateStage1_추가Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_추가Spawn01 : TriggerState {
            internal StateStage1_추가Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2837)) {
                    return new StateStage1_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_Wait01 : TriggerState {
            internal StateStage1_Wait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") <= 6) {
                    return new StateStage1_추가Spawn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_추가Spawn02 : TriggerState {
            internal StateStage1_추가Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2837)) {
                    return new StateStage1_Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_Wait02 : TriggerState {
            internal StateStage1_Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") <= 6) {
                    return new StateStage1_추가Spawn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_추가Spawn03 : TriggerState {
            internal StateStage1_추가Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3549)) {
                    return new StateStage1_Wait03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_Wait03 : TriggerState {
            internal StateStage1_Wait03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new StateStage1문파괴Wait_Stage2MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1문파괴Wait_Stage2MonsterSpawn : TriggerState {
            internal StateStage1문파괴Wait_Stage2MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.CreateMonster(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1750)) {
                    return new StateStage1_완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage1_완료 : TriggerState {
            internal StateStage1_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {61}, arg2: true);
                context.SetEffect(arg1: new[] {8801}, arg2: true);
                context.SetMesh(arg1: new[] {4001}, arg2: false);
                context.SetEffect(arg1: new[] {8100, 8101, 8102, 8103, 8104}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStage2_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_시작 : TriggerState {
            internal StateStage2_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {61}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateStage2_Wait01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_Wait01 : TriggerState {
            internal StateStage2_Wait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") <= 4) {
                    return new StateStage2_추가Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_추가Spawn01 : TriggerState {
            internal StateStage2_추가Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2221}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3549)) {
                    return new StateStage2_Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_Wait02 : TriggerState {
            internal StateStage2_Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new StateStage2문파괴Wait_Stage3MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2문파괴Wait_Stage3MonsterSpawn : TriggerState {
            internal StateStage2문파괴Wait_Stage3MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.CreateMonster(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1750)) {
                    return new StateStage2_완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_완료 : TriggerState {
            internal StateStage2_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {62}, arg2: true);
                context.SetEffect(arg1: new[] {8802}, arg2: true);
                context.SetMesh(arg1: new[] {4002}, arg2: false);
                context.SetEffect(arg1: new[] {8200, 8201, 8202, 8203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStage3_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_시작 : TriggerState {
            internal StateStage3_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {62}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2853)) {
                    return new StateStage3_진행중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_진행중 : TriggerState {
            internal StateStage3_진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new StateStage3문파괴Wait_Stage4MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3문파괴Wait_Stage4MonsterSpawn : TriggerState {
            internal StateStage3문파괴Wait_Stage4MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.CreateMonster(arg1: new[] {4001}, arg2: true);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__36$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2470)) {
                    return new StateStage3_완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_완료 : TriggerState {
            internal StateStage3_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {63}, arg2: true);
                context.SetEffect(arg1: new[] {8803}, arg2: true);
                context.SetMesh(arg1: new[] {4003}, arg2: false);
                context.SetEffect(arg1: new[] {8300, 8301, 8302, 8303, 8304}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStage4_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_시작 : TriggerState {
            internal StateStage4_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {63}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2700)) {
                    return new StateStage4_진행중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_진행중 : TriggerState {
            internal StateStage4_진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new StateStage4문파괴Wait_Stage5MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4문파괴Wait_Stage5MonsterSpawn : TriggerState {
            internal StateStage4문파괴Wait_Stage5MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MonsterMany", value: 0);
                context.CreateMonster(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1750)) {
                    return new StateStage4_완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage4_완료 : TriggerState {
            internal StateStage4_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {64}, arg2: true);
                context.SetEffect(arg1: new[] {8804}, arg2: true);
                context.SetMesh(arg1: new[] {4004}, arg2: false);
                context.SetEffect(arg1: new[] {8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412, 8413, 8414, 8415, 8416, 8417, 8418, 8419, 8420, 8421, 8422, 8423, 8424, 8425, 8426}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStage5_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_시작 : TriggerState {
            internal StateStage5_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {64}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateStage5_완료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_완료Wait : TriggerState {
            internal StateStage5_완료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterMany") == 0) {
                    return new StateStage5_완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_완료 : TriggerState {
            internal StateStage5_완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8500, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8511, 8512, 8513, 8514, 8515, 8516, 8517}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State보안게임Preparing(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보안게임Preparing : TriggerState {
            internal State보안게임Preparing(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__38$", arg3: 5000);
                context.SetInteractObject(arg1: new[] {10003145}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003145}, arg2: 0)) {
                    return new State보안게임시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보안게임시작 : TriggerState {
            internal State보안게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GameLogicEnd", value: 999);
                context.WidgetAction(type: WidgetType.Round, name: "InitWidgetRound");
                context.SetUserValue(triggerId: 9002, key: "GameLogicStart", value: 999);
                context.LockMyPc(isLock: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State문열기시작2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기시작2 : TriggerState {
            internal State문열기시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__39$", arg3: 4000);
                context.LockMyPc(isLock: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetUserValue(triggerId: 9002, key: "GameLogicStart", value: 1);
                    return new State게임로직종료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임로직종료Wait : TriggerState {
            internal State게임로직종료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GameLogicEnd") == 1) {
                    return new State게임로직종료및Success(context);
                }

                if (context.GetUserValue(key: "GameLogicEnd") == 2) {
                    return new State게임로직종료및실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및Success : TriggerState {
            internal State게임로직종료및Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new State게임로직종료(context);
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및실패 : TriggerState {
            internal State게임로직종료및실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new State실패게임로직종료(context);
            }

            public override void OnExit() { }
        }

        private class State게임로직종료 : TriggerState {
            internal State게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 3000f);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__40$", arg3: 3000);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동하자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패게임로직종료 : TriggerState {
            internal State실패게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 3000f);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__41$", arg3: 3000);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000535_BF__MAIN__42$", duration: 3500);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State문파괴안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문파괴안내 : TriggerState {
            internal State문파괴안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 1, script: "$02000535_BF__MAIN__43$", arg3: 7000);
                context.LockMyPc(isLock: false);
                context.CreateMonster(arg1: new[] {611}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {611})) {
                    return new State이동하자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동하자 : TriggerState {
            internal State이동하자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.LockMyPc(isLock: false);
                context.SideNpcTalk(npcId: 23300001, illust: "Haren_smile", duration: 4000, script: "$02000535_BF__MAIN__44$");
                context.SetMesh(arg1: new[] {4014, 4015}, arg2: false);
                context.SetEffect(arg1: new[] {8805}, arg2: true);
                context.SetPortal(portalId: 2, visible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State이동하자2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동하자2 : TriggerState {
            internal State이동하자2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8500, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8511, 8512, 8513, 8514, 8515, 8516, 8517}, arg2: false);
                context.SetEffect(arg1: new[] {8600, 8601, 8602}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$02000535_BF__MAIN__45$", duration: 3500);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}