namespace Maple2.Trigger._51000001_dg {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 49179101, arg3: 1, arg5: false);
                    context.State = new State인트로(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인트로 : TriggerState {
            internal State인트로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5000, 5001, 5002, 5003, 5101, 5102, 5103, 5104, 5105, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5601, 5602, 5603, 5604, 5605, 5606, 5607, 5608, 5609, 5610, 5611, 5612, 5613, 5614, 5615, 5616, 5617, 5618, 5619, 5620, 5621, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5716, 5717, 5718, 5719, 5720, 5721, 5801, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822, 5901, 5902, 5903, 5904, 5905, 5906, 5907, 5908, 5909, 5910, 5911, 5912, 5913, 5914, 5915, 51001, 51002, 51003, 51004, 51005, 51006, 51007, 51008, 51009, 51010, 51011, 51012, 51013, 51014, 51015, 51016, 51017, 51018, 51019, 51020, 51021, 51022, 51023, 51024}, isVisible: false);
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$51000001_DG__MAIN__0$");
                context.SetSkip(arg1: "튜토리얼시작");
            }

            public override void Execute() { }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State튜토리얼시작 : TriggerState {
            internal State튜토리얼시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5000, 5001, 5002, 5003}, randomCount: 4, isVisible: true);
                context.ShowGuideSummary(entityId: 25100101, textId: 25100101, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State튜토리얼02(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State1라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State튜토리얼02 : TriggerState {
            internal State튜토리얼02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100102, textId: 25100102, duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State튜토리얼03(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State1라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State튜토리얼03 : TriggerState {
            internal State튜토리얼03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100103, textId: 25100103, duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State튜토리얼04(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State1라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State튜토리얼04 : TriggerState {
            internal State튜토리얼04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100104, textId: 25100104, duration: 2500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State튜토리얼시작(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State1라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드카메라 : TriggerState {
            internal State1라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State1라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State1라운드대기 : TriggerState {
            internal State1라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_start");
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "arcade_startcheck");
                context.HideGuideSummary(entityId: 25100101);
                context.HideGuideSummary(entityId: 25100102);
                context.HideGuideSummary(entityId: 25100103);
                context.HideGuideSummary(entityId: 25100104);
                context.SetCube(ids: new[] {5101, 5102, 5103, 5104, 5105}, randomCount: 3, isVisible: true);
                context.ArcadeSpringFarm(type: "StartGame", lifeCount: 3);
                context.ArcadeSpringFarm(type: "SetInteractScore", id: 19000022, score: 50);
                context.ArcadeSpringFarm(type: "SetInteractScore", id: 11000013, score: 10000);
                context.ArcadeSpringFarm(type: "SetInteractScore", id: 11000014, score: 10000);
                context.ArcadeSpringFarm(type: "SetInteractScore", id: 11000015, score: 10000);
                context.ArcadeSpringFarm(type: "SetInteractScore", id: 11000016, score: 10000);
                context.ArcadeSpringFarm(type: "SetInteractScore", id: 11000017, score: 10000);
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1001, 1002, 1003}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 1, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetTimer(arg1: "100001", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.SetEventUI(arg1: 0, arg2: "1,5,1", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State1라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드시작 : TriggerState {
            internal State1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100001")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1001, 1002, 1003})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State1라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1라운드종료 : TriggerState {
            internal State1라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_1round");
                context.ArcadeSpringFarm(type: "ClearRound", round: 1);
                context.ResetTimer(arg1: "100001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 2, arg3: 101);
                    context.State = new State2라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드유저위치 : TriggerState {
            internal State2라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 2, arg3: 101);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.State = new State2라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드카메라 : TriggerState {
            internal State2라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State2라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State2라운드대기 : TriggerState {
            internal State2라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "100002", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.SetCube(ids: new[] {5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209}, randomCount: 5, isVisible: true);
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1101, 1102, 1103, 1104}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 2, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "2,5,1", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드시작 : TriggerState {
            internal State2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100002")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1101, 1102, 1103, 1104})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State2라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2라운드종료 : TriggerState {
            internal State2라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_2round");
                context.ArcadeSpringFarm(type: "ClearRound", round: 2);
                context.ResetTimer(arg1: "100002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 3, arg3: 102);
                    context.State = new State3라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드유저위치 : TriggerState {
            internal State3라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 3, arg3: 102);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    context.State = new State3라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드카메라 : TriggerState {
            internal State3라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 303, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State3라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State3라운드대기 : TriggerState {
            internal State3라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "100003", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.SetCube(ids: new[] {5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311}, randomCount: 6, isVisible: true);
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 3, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "3,5,1", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State3라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드시작 : TriggerState {
            internal State3라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100003")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State3라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3라운드종료 : TriggerState {
            internal State3라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_3round");
                context.ArcadeSpringFarm(type: "ClearRound", round: 3);
                context.ResetTimer(arg1: "100003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 4, arg3: 103);
                    context.State = new State4라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드유저위치 : TriggerState {
            internal State4라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 4, arg3: 103);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new State4라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드카메라 : TriggerState {
            internal State4라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 304, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State4라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State4라운드대기 : TriggerState {
            internal State4라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414}, randomCount: 7, isVisible: true);
                context.SetTimer(arg1: "100004", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 4, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "4,5,1", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State4라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드시작 : TriggerState {
            internal State4라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100004")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State4라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4라운드종료 : TriggerState {
            internal State4라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_4round");
                context.ArcadeSpringFarm(type: "ClearRound", round: 4);
                context.ResetTimer(arg1: "100004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 5, arg3: 104);
                    context.State = new State5라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5라운드유저위치 : TriggerState {
            internal State5라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 5, arg3: 104);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    context.State = new State5라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5라운드카메라 : TriggerState {
            internal State5라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 305, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State5라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State5라운드대기 : TriggerState {
            internal State5라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512}, randomCount: 6, isVisible: true);
                context.SetTimer(arg1: "100005", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1401, 1402, 1403, 1404, 1405}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 5, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "5,5,1", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State5라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5라운드시작 : TriggerState {
            internal State5라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100005")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1401, 1402, 1403, 1404, 1405})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State5라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5라운드종료 : TriggerState {
            internal State5라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_5round");
                context.ArcadeSpringFarm(type: "ClearRound", round: 5);
                context.ResetTimer(arg1: "100005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 6, arg3: 105);
                    context.State = new State6라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6라운드유저위치 : TriggerState {
            internal State6라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 6, arg3: 105);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    context.State = new State6라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6라운드카메라 : TriggerState {
            internal State6라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 306, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State6라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State6라운드대기 : TriggerState {
            internal State6라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5601, 5602, 5603, 5604, 5605, 5606, 5607, 5608, 5609, 5610, 5611, 5612, 5613, 5614, 5615, 5616, 5617, 5618, 5619, 5620, 5621}, randomCount: 10, isVisible: true);
                context.SetTimer(arg1: "100006", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 6, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "6,10,6", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State6라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6라운드시작 : TriggerState {
            internal State6라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100006")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State6라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6라운드종료 : TriggerState {
            internal State6라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_6round");
                context.ArcadeSpringFarm(type: "ClearRound", round: 6);
                context.ResetTimer(arg1: "100006");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 7, arg3: 106);
                    context.State = new State7라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7라운드유저위치 : TriggerState {
            internal State7라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 7, arg3: 106);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {107})) {
                    context.State = new State7라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7라운드카메라 : TriggerState {
            internal State7라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 307, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State7라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State7라운드대기 : TriggerState {
            internal State7라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5716, 5717, 5718, 5719, 5720, 5721}, randomCount: 12, isVisible: true);
                context.SetTimer(arg1: "100007", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 7, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "7,10,6", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State7라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7라운드시작 : TriggerState {
            internal State7라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100007")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State7라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7라운드종료 : TriggerState {
            internal State7라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_7round");
                context.ResetTimer(arg1: "100007");
                context.ArcadeSpringFarm(type: "ClearRound", round: 7);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 8, arg3: 107);
                    context.State = new State8라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8라운드유저위치 : TriggerState {
            internal State8라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 8, arg3: 107);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {108})) {
                    context.State = new State8라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8라운드카메라 : TriggerState {
            internal State8라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 308, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State8라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State8라운드대기 : TriggerState {
            internal State8라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5801, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822}, randomCount: 12, isVisible: true);
                context.SetTimer(arg1: "100008", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 8, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "8,10,6", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State8라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8라운드시작 : TriggerState {
            internal State8라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100008")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State8라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8라운드종료 : TriggerState {
            internal State8라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_8round");
                context.ArcadeSpringFarm(type: "ClearRound", round: 8);
                context.ResetTimer(arg1: "100008");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 9, arg3: 108);
                    context.State = new State9라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9라운드유저위치 : TriggerState {
            internal State9라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 9, arg3: 108);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {109})) {
                    context.State = new State9라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9라운드카메라 : TriggerState {
            internal State9라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 309, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State9라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State9라운드대기 : TriggerState {
            internal State9라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {5901, 5902, 5903, 5904, 5905, 5906, 5907, 5908, 5909, 5910, 5911, 5912, 5913, 5914, 5915}, randomCount: 8, isVisible: true);
                context.SetTimer(arg1: "100009", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 9, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "9,10,6", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State9라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9라운드시작 : TriggerState {
            internal State9라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100009")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State9라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9라운드종료 : TriggerState {
            internal State9라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_9round");
                context.ArcadeSpringFarm(type: "ClearRound", round: 9);
                context.ResetTimer(arg1: "100009");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 10, arg3: 109);
                    context.State = new State10라운드유저위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10라운드유저위치 : TriggerState {
            internal State10라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000001, arg2: 10, arg3: 109);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {110})) {
                    context.State = new State10라운드카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10라운드카메라 : TriggerState {
            internal State10라운드카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 310, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State10라운드대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State10라운드대기 : TriggerState {
            internal State10라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(ids: new[] {51001, 51002, 51003, 51004, 51005, 51006, 51007, 51008, 51009, 51010, 51011, 51012, 51013, 51014, 51015, 51016, 51017, 51018, 51019, 51020, 51021, 51022, 51023, 51024}, randomCount: 6, isVisible: true);
                context.SetTimer(arg1: "100010", arg2: 120, arg3: true, arg4: true, arg5: -30, arg6: "TR");
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {2001}, score: 10000);
                context.ArcadeSpringFarm(type: "SpawnMonster", spawnId: new[] {2002, 2003, 2004, 2005}, score: 5000);
                context.ArcadeSpringFarm(type: "StartRound", uiDuration: 3000, round: 10, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, arg2: "10,10,6", arg4: "120");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State10라운드시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10라운드시작 : TriggerState {
            internal State10라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 70000091);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100010")) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {2001, 2002, 2003, 2004, 2005})) {
                    context.AddBuff(arg1: new[] {199}, arg2: 70000091, arg3: 1, arg5: false);
                    context.State = new State10라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10라운드종료 : TriggerState {
            internal State10라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "springfarm_clear");
                context.ArcadeSpringFarm(type: "ClearRound", round: 10);
                context.ResetTimer(arg1: "100010");
                context.SetEventUI(arg1: 7, arg3: 2000, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(arg1: 51000001, arg2: 44, arg3: 110);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Ending_Popup_01");
                context.ArcadeSpringFarm(type: "EndGame");
                context.MoveUser(arg1: 51000001, arg2: 44, arg3: 110);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State진짜끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진짜끝 : TriggerState {
            internal State진짜끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}