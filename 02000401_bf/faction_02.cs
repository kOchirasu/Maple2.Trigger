namespace Maple2.Trigger._02000401_bf {
    public static class _faction_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 99910140);
                context.SetInteractObject(interactIds: new []{12000023, 12000024, 12000025, 12000026, 12000038}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "faction02") == 1) {
                    return new State말Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말Prepare : TriggerState {
            internal State말Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1104}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1101, script: "$02000401_BF__FACTION_02__0$", arg4: 5, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new State던전(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuest(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전 : TriggerState {
            internal State던전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateEnd체크(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetInteractObject(interactIds: new []{12000023, 12000024, 12000025, 12000026}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest : TriggerState {
            internal StateQuest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000038}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.ShowGuideSummary(entityId: 20040102, textId: 20040102, duration: 3000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.RemoveBuff(boxId: 199, skillId: 70000107);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2차안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차안내 : TriggerState {
            internal State2차안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20040105, textId: 20040105, duration: 3500);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.RemoveBuff(boxId: 199, skillId: 70000107);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    context.DestroyMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1104}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000023, 12000024, 12000025, 12000026, 12000038}, state: 0);
                    context.RemoveBuff(boxId: 199, skillId: 99910140);
                    return new StateEnd(context);
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
