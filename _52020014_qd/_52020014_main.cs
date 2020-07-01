using System;

namespace Maple2.Trigger._52020014_qd {
    public static class _52020014_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State감지(context);

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetMesh(arg1: new int[] {9101}, arg2: true);
                context.SetMesh(arg1: new int[] {9102}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {1}, arg2: false);
                context.SetMesh(arg1: new int[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010},
                    arg2: false);
                context.SetLadder(arg1: 10001, arg2: false, arg3: false);
                context.SetLadder(arg1: 10002, arg2: false, arg3: false);
                context.SetLadder(arg1: 10003, arg2: false, arg3: false);
                context.SetLadder(arg1: 10004, arg2: false, arg3: false);
                context.SetLadder(arg1: 10005, arg2: false, arg3: false);
                context.SetLadder(arg1: 10006, arg2: false, arg3: false);
                context.SetBreakable(arg1: new int[] {10001}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10002004}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002005}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {901})) {
                    context.State = new State1차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투 : TriggerState {
            internal State1차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {904})) {
                    context.State = new State2차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {104}, arg2: true);
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 102, 103, 104, 105, 106})) {
                    context.State = new State사다리발견(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리발견 : TriggerState {
            internal State사다리발견(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetMesh(arg1: new int[] {9102}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {1}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {907})) {
                    context.State = new State이펙트꺼주기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트꺼주기 : TriggerState {
            internal State이펙트꺼주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {902})) {
                    context.State = new State3차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투 : TriggerState {
            internal State3차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {111}, arg2: true);
                context.CreateMonster(arg1: new int[] {112}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {903})) {
                    context.State = new State4차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차전투 : TriggerState {
            internal State4차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {113}, arg2: true);
                context.CreateMonster(arg1: new int[] {114}, arg2: true);
                context.CreateMonster(arg1: new int[] {115}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {111, 112, 113, 114, 115})) {
                    context.State = new State이공간레버활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이공간레버활성 : TriggerState {
            internal State이공간레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002004}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002004}, arg2: 0)) {
                    context.State = new State이공간다리활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이공간다리활성 : TriggerState {
            internal State이공간다리활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010},
                    arg2: true, arg3: 0, arg4: 200, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {905})) {
                    context.State = new State레버힌트_카메라(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버힌트_카메라 : TriggerState {
            internal State레버힌트_카메라(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "이공간1차전투", arg2: "nextState");
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State레버힌트_카메라대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버힌트_카메라대사 : TriggerState {
            internal State레버힌트_카메라대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg3: "저 레버를 작동시키면 되는건가...?", arg4: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이공간1차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이공간1차전투 : TriggerState {
            internal State이공간1차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
                context.CreateMonster(arg1: new int[] {121}, arg2: true);
                context.CreateMonster(arg1: new int[] {122}, arg2: true);
                context.CreateMonster(arg1: new int[] {123}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "에고 웨폰을 모두 처치하고 레버를 작동시키세요.", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {906})) {
                    context.State = new State이공간2차전투(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이공간2차전투 : TriggerState {
            internal State이공간2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {124}, arg2: true);
                context.CreateMonster(arg1: new int[] {125}, arg2: true);
                context.CreateMonster(arg1: new int[] {126}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {121, 122, 123, 124, 125, 126})) {
                    context.State = new State사다리활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리활성 : TriggerState {
            internal State사다리활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 10001, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 10002, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 10003, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 10004, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 10005, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 10006, arg2: true, arg3: true, arg4: 10);
                context.SetInteractObject(arg1: new int[] {10002005}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002005}, arg2: 0)) {
                    context.State = new State비밀의문(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비밀의문 : TriggerState {
            internal State비밀의문(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "카메라리셋", arg2: "nextState");
                context.CameraSelect(arg1: 501, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetBreakable(arg1: new int[] {10001}, arg2: true);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new int[] {9101}, arg2: false, arg3: 0, arg4: 0, arg5: 30f);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "성공이야!", arg4: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카메라리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋 : TriggerState {
            internal State카메라리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}