namespace Maple2.Trigger._02000298_bf {
    public static class _number {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{608, 610, 611}, visible: false);
                context.SetActor(triggerId: 292, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 293, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 294, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 295, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 296, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 297, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 298, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 299, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetMesh(triggerIds: new []{3224, 3225, 3226}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{198})) {
                    return new State암호체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암호체크 : TriggerState {
            internal State암호체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002982, textId: 20002982);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 197, spawnIds: new []{1279})) {
                    return new State입력Waiting_1279(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1238})) {
                    return new State입력Waiting_1238(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1358})) {
                    return new State입력Waiting_1358(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1489})) {
                    return new State입력Waiting_1489(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1567})) {
                    return new State입력Waiting_1567(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1679})) {
                    return new State입력Waiting_1679(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2389})) {
                    return new State입력Waiting_2389(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2347})) {
                    return new State입력Waiting_2347(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2478})) {
                    return new State입력Waiting_2478(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2456})) {
                    return new State입력Waiting_2456(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2569})) {
                    return new State입력Waiting_2569(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2678})) {
                    return new State입력Waiting_2678(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{3458})) {
                    return new State입력Waiting_3458(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{3589})) {
                    return new State입력Waiting_3589(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{3679})) {
                    return new State입력Waiting_3679(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{3789})) {
                    return new State입력Waiting_3789(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{4567})) {
                    return new State입력Waiting_4567(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{4578})) {
                    return new State입력Waiting_4578(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{4689})) {
                    return new State입력Waiting_4689(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{4789})) {
                    return new State입력Waiting_4789(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_1279 : TriggerState {
            internal State입력Waiting_1279(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000001, 12000002, 12000007, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000008}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_1238 : TriggerState {
            internal State입력Waiting_1238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000001, 12000002, 12000003, 12000008}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_1358 : TriggerState {
            internal State입력Waiting_1358(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000001, 12000003, 12000005, 12000008}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_1489 : TriggerState {
            internal State입력Waiting_1489(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000001, 12000004, 12000008, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_1567 : TriggerState {
            internal State입력Waiting_1567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000001, 12000005, 12000006, 12000007}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000008}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_1679 : TriggerState {
            internal State입력Waiting_1679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000001, 12000006, 12000007, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000008}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_2389 : TriggerState {
            internal State입력Waiting_2389(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000002, 12000003, 12000008, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_2347 : TriggerState {
            internal State입력Waiting_2347(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000002, 12000003, 12000004, 12000007}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000008}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_2478 : TriggerState {
            internal State입력Waiting_2478(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000002, 12000004, 12000007, 12000008}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_2456 : TriggerState {
            internal State입력Waiting_2456(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000002, 12000004, 12000005, 12000006}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000008}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_2569 : TriggerState {
            internal State입력Waiting_2569(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000002, 12000005, 12000006, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000008}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_2678 : TriggerState {
            internal State입력Waiting_2678(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000002, 12000006, 12000007, 12000008}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_3458 : TriggerState {
            internal State입력Waiting_3458(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000003, 12000004, 12000005, 12000008}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_3589 : TriggerState {
            internal State입력Waiting_3589(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000003, 12000005, 12000008, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_3679 : TriggerState {
            internal State입력Waiting_3679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000003, 12000006, 12000007, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000008}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_3789 : TriggerState {
            internal State입력Waiting_3789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000003, 12000007, 12000008, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000004}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_4567 : TriggerState {
            internal State입력Waiting_4567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000004, 12000005, 12000006, 12000007}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000008}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_4578 : TriggerState {
            internal State입력Waiting_4578(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000004, 12000005, 12000007, 12000008}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000009}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_4689 : TriggerState {
            internal State입력Waiting_4689(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000004, 12000006, 12000008, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000007}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입력Waiting_4789 : TriggerState {
            internal State입력Waiting_4789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000004, 12000007, 12000008, 12000009}, arg2: 0)) {
                    return new State정답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000001}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000002}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000003}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000005}, arg2: 0)) {
                    return new State오답(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000006}, arg2: 0)) {
                    return new State오답(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정답 : TriggerState {
            internal State정답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002982);
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 20002983, textId: 20002983);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.HideGuideSummary(entityId: 20002983);
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEffect(triggerIds: new []{608}, visible: true);
                context.SetMesh(triggerIds: new []{3221, 3222, 3223}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{3224, 3225, 3226}, visible: true, arg3: 1000, arg4: 1000, arg5: 5f);
                context.ShowGuideSummary(entityId: 20002984, textId: 20002984);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    context.HideGuideSummary(entityId: 20002984);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오답 : TriggerState {
            internal State오답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002982);
                context.SetEffect(triggerIds: new []{610}, visible: true);
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 20002985, textId: 20002985);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetInteractObject(interactIds: new []{12000001, 12000002, 12000003, 12000004, 12000005, 12000006, 12000007, 12000008, 12000009}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.HideGuideSummary(entityId: 20002985);
                    return new State방어모드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방어모드 : TriggerState {
            internal State방어모드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 292, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 293, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 294, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 295, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 296, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 297, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 299, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 298, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetEffect(triggerIds: new []{611}, visible: true);
                context.ShowGuideSummary(entityId: 20002986, textId: 20002986);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.CreateMonster(spawnIds: new []{1098, 1099}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1098, 1099})) {
                    context.HideGuideSummary(entityId: 20002986);
                    context.SetActor(triggerId: 292, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 293, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 294, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 295, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 296, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 297, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 298, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetActor(triggerId: 299, visible: true, initialSequence: "sf_quest_light_A01_Off");
                    context.SetEffect(triggerIds: new []{611}, visible: false);
                    return new State암호체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
