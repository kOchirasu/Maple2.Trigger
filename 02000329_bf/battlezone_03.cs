namespace Maple2.Trigger._02000329_bf {
    public static class _battlezone_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6605, 6606, 6607, 6608}, arg2: false);
                context.SetMesh(arg1: new[] {1521, 1522, 1523, 1524, 1525, 1526, 1527, 1528, 1529, 1530}, arg2: true, arg3: 0, arg4: 1000, arg5: 0f);
                context.SetMesh(arg1: new[] {19993}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {703})) {
                    return new State애플몽키소환(context);
                }

                if (context.MonsterDead(arg1: new[] {1105, 1106, 1107, 1108})) {
                    return new State섹터개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State애플몽키소환 : TriggerState {
            internal State애플몽키소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 101, textId: 20000030);
                context.CreateMonster(arg1: new[] {703}, arg2: false);
                context.SetEffect(arg1: new[] {6605, 6606, 6607, 6608}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1105, 1106, 1107, 1108})) {
                    return new State섹터개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 101);
            }
        }

        private class State섹터개방 : TriggerState {
            internal State섹터개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.ShowGuideSummary(entityId: 102, textId: 40011);
                context.SetMesh(arg1: new[] {19993}, arg2: false);
                context.SetMesh(arg1: new[] {1521, 1522, 1523, 1524, 1525, 1526, 1527, 1528, 1529, 1530}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 102);
            }
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