namespace Maple2.Trigger._51000001_dg {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 49179101, level: 1, arg5: false);
                    return new State인트로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로 : TriggerState {
            internal State인트로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5000, 5001, 5002, 5003, 5101, 5102, 5103, 5104, 5105, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512, 5601, 5602, 5603, 5604, 5605, 5606, 5607, 5608, 5609, 5610, 5611, 5612, 5613, 5614, 5615, 5616, 5617, 5618, 5619, 5620, 5621, 5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5716, 5717, 5718, 5719, 5720, 5721, 5801, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822, 5901, 5902, 5903, 5904, 5905, 5906, 5907, 5908, 5909, 5910, 5911, 5912, 5913, 5914, 5915, 51001, 51002, 51003, 51004, 51005, 51006, 51007, 51008, 51009, 51010, 51011, 51012, 51013, 51014, 51015, 51016, 51017, 51018, 51019, 51020, 51021, 51022, 51023, 51024}, visible: false);
                context.CameraSelect(triggerId: 300, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$51000001_DG__MAIN__0$");
                context.SetSkip(state: new State튜토리얼시작(context));
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State튜토리얼시작 : TriggerState {
            internal State튜토리얼시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5000, 5001, 5002, 5003}, randomCount: 4, visible: true);
                context.ShowGuideSummary(entityId: 25100101, textId: 25100101, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State튜토리얼02(context);
                }

                if (context.UserDetected(boxIds: new []{101})) {
                    return new State1라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State튜토리얼02 : TriggerState {
            internal State튜토리얼02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100102, textId: 25100102, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State튜토리얼03(context);
                }

                if (context.UserDetected(boxIds: new []{101})) {
                    return new State1라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State튜토리얼03 : TriggerState {
            internal State튜토리얼03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100103, textId: 25100103, duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State튜토리얼04(context);
                }

                if (context.UserDetected(boxIds: new []{101})) {
                    return new State1라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State튜토리얼04 : TriggerState {
            internal State튜토리얼04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25100104, textId: 25100104, duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State튜토리얼시작(context);
                }

                if (context.UserDetected(boxIds: new []{101})) {
                    return new State1라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드Camera : TriggerState {
            internal State1라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State1라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State1라운드Wait : TriggerState {
            internal State1라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_start");
                context.SetAchievement(triggerId: 199, type: "trigger", code: "arcade_startcheck");
                context.HideGuideSummary(entityId: 25100101);
                context.HideGuideSummary(entityId: 25100102);
                context.HideGuideSummary(entityId: 25100103);
                context.HideGuideSummary(entityId: 25100104);
                context.SetCube(triggerIds: new []{5101, 5102, 5103, 5104, 5105}, randomCount: 3, visible: true);
                context.ArcadeSpringFarmStartGame(lifeCount: 3);
                context.ArcadeSpringFarmSetInteractScore(interactId: 19000022, score: 50);
                context.ArcadeSpringFarmSetInteractScore(interactId: 11000013, score: 10000);
                context.ArcadeSpringFarmSetInteractScore(interactId: 11000014, score: 10000);
                context.ArcadeSpringFarmSetInteractScore(interactId: 11000015, score: 10000);
                context.ArcadeSpringFarmSetInteractScore(interactId: 11000016, score: 10000);
                context.ArcadeSpringFarmSetInteractScore(interactId: 11000017, score: 10000);
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1001, 1002, 1003}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 1, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetTimer(timerId: "100001", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.SetEventUI(arg1: 0, script: "1,5,1", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State1라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드시작 : TriggerState {
            internal State1라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100001")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1001, 1002, 1003})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State1라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1라운드종료 : TriggerState {
            internal State1라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_1round");
                context.ArcadeSpringFarmClearRound(round: 1);
                context.ResetTimer(timerId: "100001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 2, boxId: 101);
                    return new State2라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드유저위치 : TriggerState {
            internal State2라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 2, boxId: 101);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State2라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드Camera : TriggerState {
            internal State2라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 302, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State2라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State2라운드Wait : TriggerState {
            internal State2라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "100002", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.SetCube(triggerIds: new []{5201, 5202, 5203, 5204, 5205, 5206, 5207, 5208, 5209}, randomCount: 5, visible: true);
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1101, 1102, 1103, 1104}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 2, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "2,5,1", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드시작 : TriggerState {
            internal State2라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100002")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1101, 1102, 1103, 1104})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State2라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2라운드종료 : TriggerState {
            internal State2라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_2round");
                context.ArcadeSpringFarmClearRound(round: 2);
                context.ResetTimer(timerId: "100002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 3, boxId: 102);
                    return new State3라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드유저위치 : TriggerState {
            internal State3라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 3, boxId: 102);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new State3라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드Camera : TriggerState {
            internal State3라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 303, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State3라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State3라운드Wait : TriggerState {
            internal State3라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "100003", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.SetCube(triggerIds: new []{5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311}, randomCount: 6, visible: true);
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1201, 1202, 1203, 1204, 1205, 1206, 1207}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 3, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "3,5,1", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드시작 : TriggerState {
            internal State3라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100003")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1201, 1202, 1203, 1204, 1205, 1206, 1207})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State3라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3라운드종료 : TriggerState {
            internal State3라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_3round");
                context.ArcadeSpringFarmClearRound(round: 3);
                context.ResetTimer(timerId: "100003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 4, boxId: 103);
                    return new State4라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드유저위치 : TriggerState {
            internal State4라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 4, boxId: 103);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new State4라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드Camera : TriggerState {
            internal State4라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 304, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State4라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State4라운드Wait : TriggerState {
            internal State4라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414}, randomCount: 7, visible: true);
                context.SetTimer(timerId: "100004", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 4, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "4,5,1", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드시작 : TriggerState {
            internal State4라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100004")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State4라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4라운드종료 : TriggerState {
            internal State4라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_4round");
                context.ArcadeSpringFarmClearRound(round: 4);
                context.ResetTimer(timerId: "100004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 5, boxId: 104);
                    return new State5라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드유저위치 : TriggerState {
            internal State5라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 5, boxId: 104);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new State5라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드Camera : TriggerState {
            internal State5라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 305, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State5라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State5라운드Wait : TriggerState {
            internal State5라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5501, 5502, 5503, 5504, 5505, 5506, 5507, 5508, 5509, 5510, 5511, 5512}, randomCount: 6, visible: true);
                context.SetTimer(timerId: "100005", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1401, 1402, 1403, 1404, 1405}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 5, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "5,5,1", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State5라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드시작 : TriggerState {
            internal State5라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100005")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1401, 1402, 1403, 1404, 1405})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State5라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5라운드종료 : TriggerState {
            internal State5라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_5round");
                context.ArcadeSpringFarmClearRound(round: 5);
                context.ResetTimer(timerId: "100005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 6, boxId: 105);
                    return new State6라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6라운드유저위치 : TriggerState {
            internal State6라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 6, boxId: 105);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new State6라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6라운드Camera : TriggerState {
            internal State6라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 306, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State6라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State6라운드Wait : TriggerState {
            internal State6라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5601, 5602, 5603, 5604, 5605, 5606, 5607, 5608, 5609, 5610, 5611, 5612, 5613, 5614, 5615, 5616, 5617, 5618, 5619, 5620, 5621}, randomCount: 10, visible: true);
                context.SetTimer(timerId: "100006", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 6, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "6,10,6", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State6라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6라운드시작 : TriggerState {
            internal State6라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100006")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State6라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6라운드종료 : TriggerState {
            internal State6라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_6round");
                context.ArcadeSpringFarmClearRound(round: 6);
                context.ResetTimer(timerId: "100006");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 7, boxId: 106);
                    return new State7라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7라운드유저위치 : TriggerState {
            internal State7라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 7, boxId: 106);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{107})) {
                    return new State7라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7라운드Camera : TriggerState {
            internal State7라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 307, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State7라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State7라운드Wait : TriggerState {
            internal State7라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5701, 5702, 5703, 5704, 5705, 5706, 5707, 5708, 5709, 5710, 5711, 5712, 5713, 5714, 5715, 5716, 5717, 5718, 5719, 5720, 5721}, randomCount: 12, visible: true);
                context.SetTimer(timerId: "100007", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 7, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "7,10,6", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State7라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7라운드시작 : TriggerState {
            internal State7라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100007")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State7라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7라운드종료 : TriggerState {
            internal State7라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_7round");
                context.ResetTimer(timerId: "100007");
                context.ArcadeSpringFarmClearRound(round: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 8, boxId: 107);
                    return new State8라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8라운드유저위치 : TriggerState {
            internal State8라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 8, boxId: 107);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{108})) {
                    return new State8라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8라운드Camera : TriggerState {
            internal State8라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 308, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State8라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State8라운드Wait : TriggerState {
            internal State8라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5801, 5802, 5803, 5804, 5805, 5806, 5807, 5808, 5809, 5810, 5811, 5812, 5813, 5814, 5815, 5816, 5817, 5818, 5819, 5820, 5821, 5822}, randomCount: 12, visible: true);
                context.SetTimer(timerId: "100008", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 8, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "8,10,6", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State8라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8라운드시작 : TriggerState {
            internal State8라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100008")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State8라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8라운드종료 : TriggerState {
            internal State8라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_8round");
                context.ArcadeSpringFarmClearRound(round: 8);
                context.ResetTimer(timerId: "100008");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 9, boxId: 108);
                    return new State9라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9라운드유저위치 : TriggerState {
            internal State9라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 9, boxId: 108);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{109})) {
                    return new State9라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9라운드Camera : TriggerState {
            internal State9라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 309, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State9라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State9라운드Wait : TriggerState {
            internal State9라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5901, 5902, 5903, 5904, 5905, 5906, 5907, 5908, 5909, 5910, 5911, 5912, 5913, 5914, 5915}, randomCount: 8, visible: true);
                context.SetTimer(timerId: "100009", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 9, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "9,10,6", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State9라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9라운드시작 : TriggerState {
            internal State9라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100009")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State9라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9라운드종료 : TriggerState {
            internal State9라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_9round");
                context.ArcadeSpringFarmClearRound(round: 9);
                context.ResetTimer(timerId: "100009");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 10, boxId: 109);
                    return new State10라운드유저위치(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10라운드유저위치 : TriggerState {
            internal State10라운드유저위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000001, portalId: 10, boxId: 109);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{110})) {
                    return new State10라운드Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10라운드Camera : TriggerState {
            internal State10라운드Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 310, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State10라운드Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State10라운드Wait : TriggerState {
            internal State10라운드Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{51001, 51002, 51003, 51004, 51005, 51006, 51007, 51008, 51009, 51010, 51011, 51012, 51013, 51014, 51015, 51016, 51017, 51018, 51019, 51020, 51021, 51022, 51023, 51024}, randomCount: 6, visible: true);
                context.SetTimer(timerId: "100010", seconds: 120, autoRemove: true, display: true, vOffset: -30, type: "TR");
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{2001}, score: 10000);
                context.ArcadeSpringFarmSpawnMonster(spawnId: new []{2002, 2003, 2004, 2005}, score: 5000);
                context.ArcadeSpringFarmStartRound(uiDuration: 3000, round: 10, timeScoreType: "remain", timeScoreRate: 500, roundDuration: 120000);
                context.SetEventUI(arg1: 0, script: "10,10,6", boxId: 120);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State10라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10라운드시작 : TriggerState {
            internal State10라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 70000091);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100010")) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{2001, 2002, 2003, 2004, 2005})) {
                    context.AddBuff(boxIds: new []{199}, skillId: 70000091, level: 1, arg5: false);
                    return new State10라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10라운드종료 : TriggerState {
            internal State10라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 199, type: "trigger", code: "springfarm_clear");
                context.ArcadeSpringFarmClearRound(round: 10);
                context.ResetTimer(timerId: "100010");
                context.SetEventUI(arg1: 7, duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 51000001, portalId: 44, boxId: 110);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Ending_Popup_01");
                context.ArcadeSpringFarmEndGame();
                context.MoveUser(mapId: 51000001, portalId: 44, boxId: 110);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State진짜끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진짜끝 : TriggerState {
            internal State진짜끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
