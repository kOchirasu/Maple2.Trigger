using System.Numerics;

namespace Maple2.Trigger._02000540_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(132f, 195f, 255f), arg2: new Vector3(0f, 0f, 0f), arg3: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(163f, 115f, 143f), arg2: new Vector3(140f, 140f, 140f));
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6002, arg2: false);
                context.SetPortal(arg1: 6003, arg2: false);
                context.SetPortal(arg1: 6004, arg2: false);
                context.SetPortal(arg1: 6005, arg2: false);
                context.SetInteractObject(arg1: new[] {10003138, 10003139, 10003140, 10003141}, arg2: 0);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.SetEffect(arg1: new[] {9000, 9001, 9002, 9003}, arg2: false);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.SetEffect(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, arg2: false);
                context.CreateMonster(arg1: new[] {614}, arg2: true);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__0$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {708}, arg2: 0)) {
                    return new State전투판으로이동하면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투판으로이동하면 : TriggerState {
            internal State전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {601, 6011, 6012}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 601, msg: "$02000540_BF__MAIN__1$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 6011, msg: "$02000540_BF__MAIN__2$", duration: 3500, delayTick: 1500);
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000540_BF__MAIN__3$");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {709}, arg2: 0)) {
                    return new State전투판으로이동하면2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투판으로이동하면2 : TriggerState {
            internal State전투판으로이동하면2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {602, 6021, 6022, 603}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 603, msg: "$02000540_BF__MAIN__4$", duration: 3500, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {601, 6011, 6012, 602, 6021, 6022, 603})) {
                    return new State첫번째오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째오브젝트조사 : TriggerState {
            internal State첫번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__5$", arg3: 3000);
                context.SetInteractObject(arg1: new[] {10003138}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003138}, arg2: 0)) {
                    return new State첫번째불켰음(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째불켰음 : TriggerState {
            internal State첫번째불켰음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8001}, arg2: true);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__6$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {704}, arg2: 0)) {
                    return new State두번째MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째MonsterCreation : TriggerState {
            internal State두번째MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {9000}, arg2: false);
                context.CreateMonster(arg1: new[] {604, 6041, 6042}, arg2: false);
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000540_BF__MAIN__7$");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {710}, arg2: 0)) {
                    return new State두번째전투판으로이동하면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째전투판으로이동하면 : TriggerState {
            internal State두번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {605, 6051, 6052, 606}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 606, msg: "$02000540_BF__MAIN__8$", duration: 3500, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {604, 6041, 6042, 605, 6051, 6052, 606})) {
                    return new State두번째오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째오브젝트조사 : TriggerState {
            internal State두번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__9$", arg3: 3000);
                context.SetInteractObject(arg1: new[] {10003139}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003139}, arg2: 0)) {
                    return new State세번째전투판체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판체크 : TriggerState {
            internal State세번째전투판체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8002}, arg2: true);
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__10$", arg3: 3000);
                context.SetEffect(arg1: new[] {8005, 8006}, arg2: true);
                context.SetPortal(arg1: 6002, arg2: true);
                context.SetPortal(arg1: 6003, arg2: true);
                context.AddBalloonTalk(spawnPointId: 614, msg: "$02000540_BF__MAIN__11$", duration: 6500, delayTick: 2000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {705}, arg2: 0)) {
                    return new State세번째MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째MonsterCreation : TriggerState {
            internal State세번째MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {9001}, arg2: false);
                context.CreateMonster(arg1: new[] {607, 6071, 6072}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {711}, arg2: 0)) {
                    return new State세번째전투판으로이동하면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판으로이동하면 : TriggerState {
            internal State세번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {608, 6081, 6082, 609}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 609, msg: "$02000540_BF__MAIN__12$", duration: 3500, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {607, 6071, 6072, 608, 6081, 6082, 609})) {
                    return new State세번째오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째오브젝트조사 : TriggerState {
            internal State세번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__13$", arg3: 3000);
                context.SetInteractObject(arg1: new[] {10003140}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003140}, arg2: 0)) {
                    return new State네번째전투판체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째전투판체크 : TriggerState {
            internal State네번째전투판체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8003}, arg2: true);
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__14$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {706}, arg2: 0)) {
                    return new State네번째MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째MonsterCreation : TriggerState {
            internal State네번째MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {9002}, arg2: false);
                context.CreateMonster(arg1: new[] {610, 6101, 6102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {712}, arg2: 0)) {
                    return new State네번째전투판으로이동하면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째전투판으로이동하면 : TriggerState {
            internal State네번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {611, 6111, 6112, 612}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 612, msg: "$02000540_BF__MAIN__15$", duration: 3500, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {610, 6101, 6102, 611, 6111, 6112, 612})) {
                    return new State네번째오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째오브젝트조사 : TriggerState {
            internal State네번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__16$", arg3: 3000);
                context.SetInteractObject(arg1: new[] {10003141}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003141}, arg2: 0)) {
                    return new StateBossCombatCompleted(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatCompleted : TriggerState {
            internal StateBossCombatCompleted(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8004}, arg2: true);
                context.SetOnetimeEffect(id: 104, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__17$", arg3: 3000);
                context.SetAmbientLight(arg1: new Vector3(237f, 225f, 255f), arg2: new Vector3(0f, 0f, 0f), arg3: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(232f, 212f, 127f), arg2: new Vector3(140f, 140f, 140f));
                context.SetPortal(arg1: 6004, arg2: true);
                context.SetPortal(arg1: 6005, arg2: true);
                context.SetEffect(arg1: new[] {8007, 8008}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossSpawn전에(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn전에 : TriggerState {
            internal StateBossSpawn전에(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000540_BF__MAIN__18$");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {707}, arg2: 0)) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {9003}, arg2: false);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
                context.SetOnetimeEffect(id: 105, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000540_BF__MAIN__19$");
                context.CreateMonster(arg1: new[] {613}, arg2: true);
                context.SetPortal(arg1: 6005, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {613})) {
                    return new State다리Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Creation : TriggerState {
            internal State다리Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000540_BF__MAIN__20$");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}