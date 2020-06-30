using System;

namespace Maple2.Trigger._52010005_qd {
    public static class _act01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State퀘스트조건01(context);

        private class State퀘스트조건01 : TriggerState {
            internal State퀘스트조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000872}, arg2: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {10002820},
                    arg3: new byte[] {2})) {
                    context.State = new StateQ1_마샤르교체01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르교체01 : TriggerState {
            internal StateQ1_마샤르교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateQ1_딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_딜레이01 : TriggerState {
            internal StateQ1_딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new StateQ1_미카등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_미카등장 : TriggerState {
            internal StateQ1_미카등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2010");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateQ1_마샤르이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르이동01 : TriggerState {
            internal StateQ1_마샤르이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1020");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8001, arg2: new int[] {102})) {
                    context.State = new StateQ1_마샤르대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르대화01 : TriggerState {
            internal StateQ1_마샤르대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52010005_QD__ACT01__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 8002, arg2: new int[] {102})) {
                    context.State = new StateQ1_마샤르대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르대화02 : TriggerState {
            internal StateQ1_마샤르대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52010005_QD__ACT01__1$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateQ1_카메라연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_카메라연출01 : TriggerState {
            internal StateQ1_카메라연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 3);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.CameraSelect(arg1: 1001, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateQ1_카메라연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_카메라연출02 : TriggerState {
            internal StateQ1_카메라연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 5);
                context.DestroyMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010005_QD__ACT01__2$", arg4: 4);
                context.SetSkip(arg1: "Q1_카메라연출03");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateQ1_카메라연출03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateQ1_카메라연출03 : TriggerState {
            internal StateQ1_카메라연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 1);
                context.CameraSelect(arg1: 1001, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateQ1_마샤르교체02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_마샤르교체02 : TriggerState {
            internal StateQ1_마샤르교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {104});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {10002821},
                    arg3: new byte[] {2})) {
                    context.State = new StateQ1_퇴장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ1_퇴장 : TriggerState {
            internal StateQ1_퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {202});
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}