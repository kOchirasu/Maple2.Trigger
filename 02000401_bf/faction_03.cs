namespace Maple2.Trigger._02000401_bf {
    public static class _faction_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 199, skillId: 99910130);
                context.SetInteractObject(interactIds: new []{12000027, 12000028, 12000039}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "faction03") == 1) {
                    return new State탱크Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탱크Prepare : TriggerState {
            internal State탱크Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2903});
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20040103, textId: 20040103, duration: 3500);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.CameraSelect(triggerId: 302, enabled: true);
                context.CreateMonster(spawnIds: new []{1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1201, script: "$02000401_BF__FACTION_03__0$", arg4: 5, arg5: 0);
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
                context.SetInteractObject(interactIds: new []{12000027, 12000028}, state: 1);
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
                context.SetInteractObject(interactIds: new []{12000039}, state: 1);
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
                context.ShowGuideSummary(entityId: 20040106, textId: 20040106, duration: 3500);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.RemoveBuff(boxId: 199, skillId: 70000107);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    context.DestroyMonster(spawnIds: new []{1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000027, 12000028, 12000039}, state: 0);
                    context.RemoveBuff(boxId: 199, skillId: 99910130);
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
