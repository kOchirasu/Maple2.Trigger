using System;

namespace Maple2.Trigger._52020031_qd {
    public static class _main30000333 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {30000333},
                    arg3: new byte[] {1})) {
                    context.State = new State두번째연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출준비 : TriggerState {
            internal State두번째연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State두번째연출준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출준비_01 : TriggerState {
            internal State두번째연출준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State두번째연출준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출준비_02 : TriggerState {
            internal State두번째연출준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020031, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State두번째연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출 : TriggerState {
            internal State두번째연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 0, msg: "천공의 심장을 돌려줘.", duration: 3000);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    context.State = new State두번째연출_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출_01 : TriggerState {
            internal State두번째연출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4010}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State두번째연출_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출_02 : TriggerState {
            internal State두번째연출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003756, msg: "곱게 가져갈 수 있을 거라고 생각해?", duration: 3000);
                context.AddCinematicTalk(npcID: 11003756, msg: "꿈도 야무지다니까... 호호호", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State두번째연출_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출_03 : TriggerState {
            internal State두번째연출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4012}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째연출전투준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출전투준비_01 : TriggerState {
            internal State두번째연출전투준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State두번째연출전투준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출전투준비 : TriggerState {
            internal State두번째연출전투준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State두번째연출전투준비1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출전투준비1 : TriggerState {
            internal State두번째연출전투준비1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {601}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "하렌을 처치하세요!", arg3: new int[] {2000}, arg4: "0");
                context.AddBalloonTalk(spawnPointID: 601, msg: "숨통을 끊어주마.", duration: 3000, delayTick: 3000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {601})) {
                    context.State = new State두번째연출전투종료1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출전투종료1 : TriggerState {
            internal State두번째연출전투종료1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.5f);
                context.MoveUser(arg1: 52020031, arg2: 6001);
                context.DestroyMonster(arg1: new int[] {601});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째연출전투종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째연출전투종료2 : TriggerState {
            internal State두번째연출전투종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}