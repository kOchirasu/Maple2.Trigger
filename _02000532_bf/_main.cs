using System;

namespace Maple2.Trigger._02000532_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: true);
                context.SetMesh(arg1: new int[] {3002, 3003}, arg2: true);
                context.SetMesh(arg1: new int[] {3004}, arg2: true);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetEffect(arg1: new int[] {7006}, arg2: false);
                context.SetEffect(arg1: new int[] {7007}, arg2: false);
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip();
                context.CreateMonster(arg1: new int[] {216, 101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113},
                    arg2: true);
                context.CreateMonster(arg1: new int[] {110, 111}, arg2: true);
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_8000");
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_8001");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "목표", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {604, 603}, arg2: 1);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ShowCaption(type: "VerticalCaption", title: "$02000532_BF__MAIN__0$",
                    desc: "$02000532_BF__MAIN__1$", align: "centerRight", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State목표(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State목표 : TriggerState {
            internal State목표(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.LockMyPc(isLock: false);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, arg2: "$02000532_BF__MAIN__2$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State문들어가기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문들어가기 : TriggerState {
            internal State문들어가기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000532_BF__MAIN__3$", arg3: new int[] {3000});
                context.SetEffect(arg1: new int[] {7006}, arg2: true);
                context.SetEffect(arg1: new int[] {7007}, arg2: true);
                context.CreateMonster(arg1: new int[] {408}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {408}, arg2: false)) {
                    context.State = new State문이열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문이열림 : TriggerState {
            internal State문이열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3004}, arg2: false);
                context.AddBalloonTalk(spawnPointID: 112, msg: "$02000532_BF__MAIN__4$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 112, msg: "$02000532_BF__MAIN__5$", duration: 3500,
                    delayTick: 3500);
                context.AddBalloonTalk(spawnPointID: 102, msg: "$02000532_BF__MAIN__6$", duration: 3500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 113, msg: "$02000532_BF__MAIN__7$", duration: 3500,
                    delayTick: 900);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 10000f);
                context.SetNpcEmotionLoop(arg1: 113, arg2: "Sit_Down_A", arg3: 10000f);
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Talk_A", arg3: 10000f);
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: false);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "702", arg2: 0)) {
                    context.State = new State경계하기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경계하기 : TriggerState {
            internal State경계하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.LockMyPc(isLock: true);
                context.SetSceneSkip(arg1: "흑성회의반격", arg2: "nextState");
                context.AddBalloonTalk(spawnPointID: 104, msg: "$02000532_BF__MAIN__8$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 105, msg: "$02000532_BF__MAIN__9$", duration: 3500,
                    delayTick: 2500);
                context.AddBalloonTalk(spawnPointID: 103, msg: "$02000532_BF__MAIN__10$", duration: 3500,
                    delayTick: 2800);
                context.SetEffect(arg1: new int[] {7006}, arg2: false);
                context.SetEffect(arg1: new int[] {7007}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State통신을받은제이부하(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통신을받은제이부하 : TriggerState {
            internal State통신을받은제이부하(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {602}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State통신을받은제이부하2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State통신을받은제이부하2 : TriggerState {
            internal State통신을받은제이부하2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 205, msg: "$02000532_BF__MAIN__11$", duration: 3500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 300, msg: "$02000532_BF__MAIN__12$", duration: 3500,
                    delayTick: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State불안한제이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불안한제이 : TriggerState {
            internal State불안한제이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State불안한제이2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불안한제이2 : TriggerState {
            internal State불안한제이2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004639, illust: "Jay_normal", duration: 4000,
                    script: "$02000532_BF__MAIN__13$");
                context.AddBalloonTalk(spawnPointID: 205, msg: "$02000532_BF__MAIN__14$", duration: 3500,
                    delayTick: 4100);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State흑성회의반격(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회의반격 : TriggerState {
            internal State흑성회의반격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetMesh(arg1: new int[] {3002, 3003}, arg2: false);
                context.LockMyPc(isLock: false);
                context.CameraReset(interpolationTime: 1f);
                context.SetEventUI(arg1: 1, arg2: "$02000532_BF__MAIN__15$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State흑성회의반격2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회의반격2 : TriggerState {
            internal State흑성회의반격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113});
                context.CreateMonster(arg1: new int[] {401, 402, 403, 404, 412, 405}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State흑성회의반격22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흑성회의반격22 : TriggerState {
            internal State흑성회의반격22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 21450001, illust: "Mafia1_normal", duration: 3000,
                    script: "$02000532_BF__MAIN__16$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State골목체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State골목체크 : TriggerState {
            internal State골목체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004639, illust: "Jay_normal", duration: 3000,
                    script: "$02000532_BF__MAIN__17$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "705", arg2: 0)) {
                    context.State = new State길목에서나오는몬스터(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State길목에서나오는몬스터 : TriggerState {
            internal State길목에서나오는몬스터(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {108, 109});
                context.CreateMonster(arg1: new int[] {406, 407, 409, 410, 411}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 409, msg: "$02000532_BF__MAIN__18$", duration: 3500,
                    delayTick: 1500);
                context.AddBalloonTalk(spawnPointID: 410, msg: "$02000532_BF__MAIN__19$", duration: 3500,
                    delayTick: 1500);
                context.AddBalloonTalk(spawnPointID: 407, msg: "$02000532_BF__MAIN__20$", duration: 3500,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {401, 402, 403, 404, 405, 406, 407, 409, 410, 411, 412})) {
                    context.State = new State2차생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차생성 : TriggerState {
            internal State2차생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004639, illust: "Jay_normal", duration: 3000,
                    script: "$02000532_BF__MAIN__21$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엘리베이터안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터안내 : TriggerState {
            internal State엘리베이터안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000532_BF__MAIN__22$", arg3: new int[] {3000});
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}