namespace Maple2.Trigger._52100031_qd {
    public static class _faction_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.RemoveBuff(boxId: 199, skillId: 99910160);
                context.SetInteractObject(interactIds: new []{10002066, 10002070}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "faction04") == 1) {
                    return new State인원수체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인원수체크 : TriggerState {
            internal State인원수체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new State반응Wait(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{2902});
                context.AddBuff(boxIds: new []{199}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 303, enabled: true);
                context.CreateMonster(spawnIds: new []{1300}, arg2: true);
                context.CreateMonster(spawnIds: new []{1301, 1302, 1303, 1304, 1305}, arg2: false);
                context.SetConversation(type: 1, spawnId: 1301, script: "$52100031_QD__FACTION_04__0$", arg4: 5, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 20040104, textId: 20040104, duration: 2500);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.RemoveBuff(boxId: 199, skillId: 70000107);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "NPClanding") == 1) {
                    return new StateQuest(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest : TriggerState {
            internal StateQuest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002070}, state: 1);
                context.SetEffect(triggerIds: new []{601}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환 : TriggerState {
            internal StateBoss소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20040107, textId: 20040107, duration: 3000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.CreateMonster(spawnIds: new []{2099}, arg2: false);
                context.SetUserValue(triggerId: 99999100, key: "bossSpawn", value: 1);
                context.DestroyMonster(spawnIds: new []{1300}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    context.DestroyMonster(spawnIds: new []{1300, 1301, 1302, 1303, 1304, 1305}, arg2: false);
                    context.SetInteractObject(interactIds: new []{10002066, 10002070}, state: 0);
                    context.RemoveBuff(boxId: 199, skillId: 99910160);
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
