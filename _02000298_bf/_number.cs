using System;

namespace Maple2.Trigger._02000298_bf {
    public static class _number {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {608}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetMesh(arg1: new int[] {3224, 3225, 3226}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "198")) {
                    context.State = new State암호체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암호체크 : TriggerState {
            internal State암호체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20002982, textID: 20002982);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 197, arg2: new int[] {1279})) {
                    context.State = new State입력대기중_1279(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1238})) {
                    context.State = new State입력대기중_1238(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1358})) {
                    context.State = new State입력대기중_1358(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1489})) {
                    context.State = new State입력대기중_1489(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1567})) {
                    context.State = new State입력대기중_1567(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {1679})) {
                    context.State = new State입력대기중_1679(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2389})) {
                    context.State = new State입력대기중_2389(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2347})) {
                    context.State = new State입력대기중_2347(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2478})) {
                    context.State = new State입력대기중_2478(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2456})) {
                    context.State = new State입력대기중_2456(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2569})) {
                    context.State = new State입력대기중_2569(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {2678})) {
                    context.State = new State입력대기중_2678(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {3458})) {
                    context.State = new State입력대기중_3458(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {3589})) {
                    context.State = new State입력대기중_3589(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {3679})) {
                    context.State = new State입력대기중_3679(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {3789})) {
                    context.State = new State입력대기중_3789(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {4567})) {
                    context.State = new State입력대기중_4567(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {4578})) {
                    context.State = new State입력대기중_4578(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {4689})) {
                    context.State = new State입력대기중_4689(context);
                    return;
                }

                if (context.NpcDetected(arg1: 197, arg2: new int[] {4789})) {
                    context.State = new State입력대기중_4789(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_1279 : TriggerState {
            internal State입력대기중_1279(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000001, 12000002, 12000007, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000008}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_1238 : TriggerState {
            internal State입력대기중_1238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000001, 12000002, 12000003, 12000008}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_1358 : TriggerState {
            internal State입력대기중_1358(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000001, 12000003, 12000005, 12000008}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_1489 : TriggerState {
            internal State입력대기중_1489(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000001, 12000004, 12000008, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_1567 : TriggerState {
            internal State입력대기중_1567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000001, 12000005, 12000006, 12000007}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000008}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_1679 : TriggerState {
            internal State입력대기중_1679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000001, 12000006, 12000007, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000008}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_2389 : TriggerState {
            internal State입력대기중_2389(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000002, 12000003, 12000008, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_2347 : TriggerState {
            internal State입력대기중_2347(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000002, 12000003, 12000004, 12000007}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000008}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_2478 : TriggerState {
            internal State입력대기중_2478(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000002, 12000004, 12000007, 12000008}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_2456 : TriggerState {
            internal State입력대기중_2456(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000002, 12000004, 12000005, 12000006}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000008}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_2569 : TriggerState {
            internal State입력대기중_2569(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000002, 12000005, 12000006, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000008}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_2678 : TriggerState {
            internal State입력대기중_2678(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000002, 12000006, 12000007, 12000008}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_3458 : TriggerState {
            internal State입력대기중_3458(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000003, 12000004, 12000005, 12000008}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_3589 : TriggerState {
            internal State입력대기중_3589(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000003, 12000005, 12000008, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_3679 : TriggerState {
            internal State입력대기중_3679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000003, 12000006, 12000007, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000008}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_3789 : TriggerState {
            internal State입력대기중_3789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000003, 12000007, 12000008, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000004}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_4567 : TriggerState {
            internal State입력대기중_4567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000004, 12000005, 12000006, 12000007}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000008}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_4578 : TriggerState {
            internal State입력대기중_4578(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000004, 12000005, 12000007, 12000008}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000009}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_4689 : TriggerState {
            internal State입력대기중_4689(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000004, 12000006, 12000008, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000007}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State입력대기중_4789 : TriggerState {
            internal State입력대기중_4789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000004, 12000007, 12000008, 12000009}, arg2: 0)) {
                    context.State = new State정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000001}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000002}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000003}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000005}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000006}, arg2: 0)) {
                    context.State = new State오답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정답 : TriggerState {
            internal State정답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002982);
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityID: 20002983, textID: 20002983);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityID: 20002983);
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEffect(arg1: new int[] {608}, arg2: true);
                context.SetMesh(arg1: new int[] {3221, 3222, 3223}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new int[] {3224, 3225, 3226}, arg2: true, arg3: 1000, arg4: 1000, arg5: 5f);
                context.ShowGuideSummary(entityID: 20002984, textID: 20002984);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.HideGuideSummary(entityID: 20002984);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오답 : TriggerState {
            internal State오답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002982);
                context.SetEffect(arg1: new int[] {610}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityID: 20002985, textID: 20002985);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(
                    arg1: new int[]
                        {12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009},
                    arg2: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityID: 20002985);
                    context.State = new State방어모드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방어모드 : TriggerState {
            internal State방어모드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetEffect(arg1: new int[] {611}, arg2: true);
                context.ShowGuideSummary(entityID: 20002986, textID: 20002986);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CreateMonster(arg1: new int[] {1098, 1099}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1098, 1099})) {
                    context.HideGuideSummary(entityID: 20002986);
                    context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetEffect(arg1: new int[] {611}, arg2: false);
                    context.State = new State암호체크(context);
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