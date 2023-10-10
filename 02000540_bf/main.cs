using System.Numerics;

namespace Maple2.Trigger._02000540_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(132f, 195f, 255f));
                context.SetDirectionalLight(diffuseColor: new Vector3(163f, 115f, 143f), specularColor: new Vector3(140f, 140f, 140f));
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6002, visible: false);
                context.SetPortal(portalId: 6003, visible: false);
                context.SetPortal(portalId: 6004, visible: false);
                context.SetPortal(portalId: 6005, visible: false);
                context.SetInteractObject(interactIds: new []{10003138, 10003139, 10003140, 10003141}, state: 0);
                context.EnableSpawnPointPc(spawnId: 0, enabled: true);
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.SetEffect(triggerIds: new []{9000, 9001, 9002, 9003}, visible: false);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetEffect(triggerIds: new []{8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: false);
                context.CreateMonster(spawnIds: new []{614}, arg2: true);
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{708}, jobCode: 0)) {
                    return new State전투판으로이동하면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투판으로이동하면 : TriggerState {
            internal State전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{601, 6011, 6012}, arg2: true);
                context.AddBalloonTalk(spawnId: 601, msg: "$02000540_BF__MAIN__1$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 6011, msg: "$02000540_BF__MAIN__2$", duration: 3500, delayTick: 1500);
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000540_BF__MAIN__3$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{709}, jobCode: 0)) {
                    return new State전투판으로이동하면2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투판으로이동하면2 : TriggerState {
            internal State전투판으로이동하면2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{602, 6021, 6022, 603}, arg2: true);
                context.AddBalloonTalk(spawnId: 603, msg: "$02000540_BF__MAIN__4$", duration: 3500, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 6011, 6012, 602, 6021, 6022, 603})) {
                    return new State첫번째오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째오브젝트조사 : TriggerState {
            internal State첫번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__5$", duration: 3000);
                context.SetInteractObject(interactIds: new []{10003138}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003138}, arg2: 0)) {
                    return new State첫번째불켰음(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째불켰음 : TriggerState {
            internal State첫번째불켰음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8001}, visible: true);
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{704}, jobCode: 0)) {
                    return new State두번째MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째MonsterCreation : TriggerState {
            internal State두번째MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{9000}, visible: false);
                context.CreateMonster(spawnIds: new []{604, 6041, 6042}, arg2: false);
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000540_BF__MAIN__7$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{710}, jobCode: 0)) {
                    return new State두번째전투판으로이동하면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째전투판으로이동하면 : TriggerState {
            internal State두번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{605, 6051, 6052, 606}, arg2: true);
                context.AddBalloonTalk(spawnId: 606, msg: "$02000540_BF__MAIN__8$", duration: 3500, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{604, 6041, 6042, 605, 6051, 6052, 606})) {
                    return new State두번째오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째오브젝트조사 : TriggerState {
            internal State두번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__9$", duration: 3000);
                context.SetInteractObject(interactIds: new []{10003139}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003139}, arg2: 0)) {
                    return new State세번째전투판체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판체크 : TriggerState {
            internal State세번째전투판체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8002}, visible: true);
                context.SetOnetimeEffect(id: 102, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__10$", duration: 3000);
                context.SetEffect(triggerIds: new []{8005, 8006}, visible: true);
                context.SetPortal(portalId: 6002, visible: true);
                context.SetPortal(portalId: 6003, visible: true);
                context.AddBalloonTalk(spawnId: 614, msg: "$02000540_BF__MAIN__11$", duration: 6500, delayTick: 2000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705}, jobCode: 0)) {
                    return new State세번째MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째MonsterCreation : TriggerState {
            internal State세번째MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{9001}, visible: false);
                context.CreateMonster(spawnIds: new []{607, 6071, 6072}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{711}, jobCode: 0)) {
                    return new State세번째전투판으로이동하면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판으로이동하면 : TriggerState {
            internal State세번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{608, 6081, 6082, 609}, arg2: true);
                context.AddBalloonTalk(spawnId: 609, msg: "$02000540_BF__MAIN__12$", duration: 3500, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{607, 6071, 6072, 608, 6081, 6082, 609})) {
                    return new State세번째오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째오브젝트조사 : TriggerState {
            internal State세번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__13$", duration: 3000);
                context.SetInteractObject(interactIds: new []{10003140}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003140}, arg2: 0)) {
                    return new State네번째전투판체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째전투판체크 : TriggerState {
            internal State네번째전투판체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8003}, visible: true);
                context.SetOnetimeEffect(id: 103, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__14$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{706}, jobCode: 0)) {
                    return new State네번째MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째MonsterCreation : TriggerState {
            internal State네번째MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{9002}, visible: false);
                context.CreateMonster(spawnIds: new []{610, 6101, 6102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{712}, jobCode: 0)) {
                    return new State네번째전투판으로이동하면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째전투판으로이동하면 : TriggerState {
            internal State네번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{611, 6111, 6112, 612}, arg2: true);
                context.AddBalloonTalk(spawnId: 612, msg: "$02000540_BF__MAIN__15$", duration: 3500, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{610, 6101, 6102, 611, 6111, 6112, 612})) {
                    return new State네번째오브젝트조사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째오브젝트조사 : TriggerState {
            internal State네번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__16$", duration: 3000);
                context.SetInteractObject(interactIds: new []{10003141}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003141}, arg2: 0)) {
                    return new StateBossCombatCompleted(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatCompleted : TriggerState {
            internal StateBossCombatCompleted(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8004}, visible: true);
                context.SetOnetimeEffect(id: 104, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, script: "$02000540_BF__MAIN__17$", duration: 3000);
                context.SetAmbientLight(color: new Vector3(237f, 225f, 255f));
                context.SetDirectionalLight(diffuseColor: new Vector3(232f, 212f, 127f), specularColor: new Vector3(140f, 140f, 140f));
                context.SetPortal(portalId: 6004, visible: true);
                context.SetPortal(portalId: 6005, visible: true);
                context.SetEffect(triggerIds: new []{8007, 8008}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{707}, jobCode: 0)) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{9003}, visible: false);
                context.EnableSpawnPointPc(spawnId: 0, enabled: false);
                context.EnableSpawnPointPc(spawnId: 1, enabled: true);
                context.SetOnetimeEffect(id: 105, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 3000, script: "$02000540_BF__MAIN__19$");
                context.CreateMonster(spawnIds: new []{613}, arg2: true);
                context.SetPortal(portalId: 6005, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{613})) {
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
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
