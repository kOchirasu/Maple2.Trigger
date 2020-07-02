namespace Maple2.Trigger._52100031_qd {
    public static class _faction_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 199, arg2: 99910130);
                context.SetInteractObject(arg1: new[] {10002064, 10002065, 10002069}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "faction03") == 1) {
                    return new State탱크준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탱크준비 : TriggerState {
            internal State탱크준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "Quest");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {2903});
                context.AddBuff(arg1: new[] {199}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20040103, textId: 20040103, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CameraSelect(arg1: 302, arg2: true);
                context.CreateMonster(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1201, arg3: "$52100031_QD__FACTION_03__0$", arg4: 5, arg5: 0);
                context.SetInteractObject(arg1: new[] {10002069}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateQuest(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest : TriggerState {
            internal StateQuest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20040106, textId: 20040106, duration: 3500);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.RemoveBuff(arg1: 199, arg2: 70000107);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    context.DestroyMonster(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208}, arg2: false);
                    context.SetInteractObject(arg1: new[] {10002064, 10002065, 10002069}, arg2: 0);
                    context.RemoveBuff(arg1: 199, arg2: 99910130);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}