using System;

namespace Maple2.Trigger._52000043_qd {
    public static class _50001453 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1003, 2003});
                context.SetAgent(arg1: "9000", arg2: false);
                context.SetAgent(arg1: "9001", arg2: false);
                context.SetAgent(arg1: "9002", arg2: false);
                context.SetAgent(arg1: "9003", arg2: false);
                context.SetAgent(arg1: "9004", arg2: false);
                context.SetAgent(arg1: "9005", arg2: false);
                context.SetAgent(arg1: "9006", arg2: false);
                context.SetAgent(arg1: "9007", arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {199}, arg2: new int[] {50001453},
                    arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new int[] {1003, 2003});
                    context.State = new State시작조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작조건 : TriggerState {
            internal State시작조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1003, 2003}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                        3016, 3017
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001020}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001021}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001021}, arg2: 0)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9000", arg2: true);
                context.SetAgent(arg1: "9001", arg2: true);
                context.SetAgent(arg1: "9002", arg2: true);
                context.SetAgent(arg1: "9003", arg2: true);
                context.SetAgent(arg1: "9004", arg2: true);
                context.SetAgent(arg1: "9005", arg2: true);
                context.SetAgent(arg1: "9006", arg2: true);
                context.SetAgent(arg1: "9007", arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {2100, 2101}, arg2: false);
                context.CameraSelect(arg1: 303, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1004A");
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData_2004A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPC대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01 : TriggerState {
            internal StateNPC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 29000121, arg3: "$52000043_QD__50001453__0$", arg4: 3);
                context.SetSkip(arg1: "NPC대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State준타대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01스킵 : TriggerState {
            internal StateNPC대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준타대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사01 : TriggerState {
            internal State준타대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001453__1$", arg4: 3);
                context.SetSkip(arg1: "준타대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State준타대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사01스킵 : TriggerState {
            internal State준타대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State준타대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사02 : TriggerState {
            internal State준타대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001453__2$", arg4: 2);
                context.SetSkip(arg1: "준타대사02스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State틴차이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준타대사02스킵 : TriggerState {
            internal State준타대사02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State틴차이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01 : TriggerState {
            internal State틴차이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {605}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001453__3$", arg4: 4);
                context.SetSkip(arg1: "틴차이대사01스킵");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State틴차이대사01스킵 : TriggerState {
            internal State틴차이대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1003, 2003});
                context.CreateMonster(arg1: new int[] {1004, 2004}, arg2: false);
                context.SetAgent(arg1: "9000", arg2: false);
                context.SetAgent(arg1: "9001", arg2: false);
                context.SetAgent(arg1: "9002", arg2: false);
                context.SetAgent(arg1: "9003", arg2: false);
                context.SetAgent(arg1: "9004", arg2: false);
                context.SetAgent(arg1: "9005", arg2: false);
                context.SetAgent(arg1: "9006", arg2: false);
                context.SetAgent(arg1: "9007", arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 303, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2100, 2101})) {
                    context.State = new State연출02시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출02시작 : TriggerState {
            internal State연출02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetInteractObject(arg1: new int[] {10001021}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1002C");
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData_2002C");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new int[] {1004})) {
                    context.State = new StateNPC교체01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC교체01 : TriggerState {
            internal StateNPC교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1004});
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new int[] {2004})) {
                    context.State = new StateNPC교체02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC교체02 : TriggerState {
            internal StateNPC교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2004});
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료2 : TriggerState {
            internal State연출종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
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