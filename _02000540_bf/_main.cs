using System;
using System.Numerics;

namespace Maple2.Trigger._02000540_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(132f, 195f, 255f), arg2: new Vector3(0f, 0f, 0f),
                    arg3: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(163f, 115f, 143f), arg2: new Vector3(140f, 140f, 140f));
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6002, arg2: false);
                context.SetPortal(arg1: 6003, arg2: false);
                context.SetPortal(arg1: 6004, arg2: false);
                context.SetPortal(arg1: 6005, arg2: false);
                context.SetInteractObject(arg1: new int[] {10003138}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10003139}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10003140}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10003141}, arg2: 0);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.SetEffect(arg1: new int[] {9000}, arg2: false);
                context.SetEffect(arg1: new int[] {9001}, arg2: false);
                context.SetEffect(arg1: new int[] {9002}, arg2: false);
                context.SetEffect(arg1: new int[] {9003}, arg2: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: true);
                context.SetEffect(arg1: new int[] {8001}, arg2: false);
                context.SetEffect(arg1: new int[] {8002}, arg2: false);
                context.SetEffect(arg1: new int[] {8003}, arg2: false);
                context.SetEffect(arg1: new int[] {8004}, arg2: false);
                context.SetEffect(arg1: new int[] {8005}, arg2: false);
                context.SetEffect(arg1: new int[] {8006}, arg2: false);
                context.SetEffect(arg1: new int[] {8007}, arg2: false);
                context.SetEffect(arg1: new int[] {8008}, arg2: false);
                context.CreateMonster(arg1: new int[] {614}, arg2: true);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "701", arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__0$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "708", arg2: 0)) {
                    context.State = new State전투판으로이동하면(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투판으로이동하면 : TriggerState {
            internal State전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {601, 6011, 6012}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 601, msg: "$02000540_BF__MAIN__1$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 6011, msg: "$02000540_BF__MAIN__2$", duration: 3500,
                    delayTick: 1500);
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000540_BF__MAIN__3$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "709", arg2: 0)) {
                    context.State = new State전투판으로이동하면2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투판으로이동하면2 : TriggerState {
            internal State전투판으로이동하면2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {602, 6021, 6022, 603}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 603, msg: "$02000540_BF__MAIN__4$", duration: 3500,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {601, 6011, 6012, 602, 6021, 6022, 603})) {
                    context.State = new State첫번째오브젝트조사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째오브젝트조사 : TriggerState {
            internal State첫번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__5$", arg3: new int[] {3000});
                context.SetInteractObject(arg1: new int[] {10003138}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003138}, arg2: 0)) {
                    context.State = new State첫번째불켰음(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째불켰음 : TriggerState {
            internal State첫번째불켰음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8001}, arg2: true);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__6$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "704", arg2: 0)) {
                    context.State = new State두번째몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째몬스터생성 : TriggerState {
            internal State두번째몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {9000}, arg2: false);
                context.CreateMonster(arg1: new int[] {604, 6041, 6042}, arg2: false);
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000540_BF__MAIN__7$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "710", arg2: 0)) {
                    context.State = new State두번째전투판으로이동하면(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째전투판으로이동하면 : TriggerState {
            internal State두번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {605, 6051, 6052, 606}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 606, msg: "$02000540_BF__MAIN__8$", duration: 3500,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {604, 6041, 6042, 605, 6051, 6052, 606})) {
                    context.State = new State두번째오브젝트조사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째오브젝트조사 : TriggerState {
            internal State두번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__9$", arg3: new int[] {3000});
                context.SetInteractObject(arg1: new int[] {10003139}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003139}, arg2: 0)) {
                    context.State = new State세번째전투판체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째전투판체크 : TriggerState {
            internal State세번째전투판체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8002}, arg2: true);
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__10$", arg3: new int[] {3000});
                context.SetEffect(arg1: new int[] {8005}, arg2: true);
                context.SetEffect(arg1: new int[] {8006}, arg2: true);
                context.SetPortal(arg1: 6002, arg2: true);
                context.SetPortal(arg1: 6003, arg2: true);
                context.AddBalloonTalk(spawnPointID: 614, msg: "$02000540_BF__MAIN__11$", duration: 6500,
                    delayTick: 2000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "705", arg2: 0)) {
                    context.State = new State세번째몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째몬스터생성 : TriggerState {
            internal State세번째몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {9001}, arg2: false);
                context.CreateMonster(arg1: new int[] {607, 6071, 6072}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "711", arg2: 0)) {
                    context.State = new State세번째전투판으로이동하면(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째전투판으로이동하면 : TriggerState {
            internal State세번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {608, 6081, 6082, 609}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 609, msg: "$02000540_BF__MAIN__12$", duration: 3500,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {607, 6071, 6072, 608, 6081, 6082, 609})) {
                    context.State = new State세번째오브젝트조사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째오브젝트조사 : TriggerState {
            internal State세번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__13$", arg3: new int[] {3000});
                context.SetInteractObject(arg1: new int[] {10003140}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003140}, arg2: 0)) {
                    context.State = new State네번째전투판체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째전투판체크 : TriggerState {
            internal State네번째전투판체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8003}, arg2: true);
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__14$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "706", arg2: 0)) {
                    context.State = new State네번째몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째몬스터생성 : TriggerState {
            internal State네번째몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {9002}, arg2: false);
                context.CreateMonster(arg1: new int[] {610, 6101, 6102}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "712", arg2: 0)) {
                    context.State = new State네번째전투판으로이동하면(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째전투판으로이동하면 : TriggerState {
            internal State네번째전투판으로이동하면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {611, 6111, 6112, 612}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 612, msg: "$02000540_BF__MAIN__15$", duration: 3500,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {610, 6101, 6102, 611, 6111, 6112, 612})) {
                    context.State = new State네번째오브젝트조사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째오브젝트조사 : TriggerState {
            internal State네번째오브젝트조사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__16$", arg3: new int[] {3000});
                context.SetInteractObject(arg1: new int[] {10003141}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003141}, arg2: 0)) {
                    context.State = new State보스전투판완성시키기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투판완성시키기 : TriggerState {
            internal State보스전투판완성시키기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8004}, arg2: true);
                context.SetOnetimeEffect(id: 104, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEventUI(arg1: 1, arg2: "$02000540_BF__MAIN__17$", arg3: new int[] {3000});
                context.SetAmbientLight(arg1: new Vector3(237f, 225f, 255f), arg2: new Vector3(0f, 0f, 0f),
                    arg3: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(232f, 212f, 127f), arg2: new Vector3(140f, 140f, 140f));
                context.SetPortal(arg1: 6004, arg2: true);
                context.SetPortal(arg1: 6005, arg2: true);
                context.SetEffect(arg1: new int[] {8007}, arg2: true);
                context.SetEffect(arg1: new int[] {8008}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State보스등장전에(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장전에 : TriggerState {
            internal State보스등장전에(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000540_BF__MAIN__18$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "707", arg2: 0)) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {9003}, arg2: false);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: true);
                context.SetOnetimeEffect(id: 105, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000540_BF__MAIN__19$");
                context.CreateMonster(arg1: new int[] {613}, arg2: true);
                context.SetPortal(arg1: 6005, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {613})) {
                    context.State = new State다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리생성 : TriggerState {
            internal State다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 3000,
                    script: "$02000540_BF__MAIN__20$");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}