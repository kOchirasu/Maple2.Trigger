namespace Maple2.Trigger._02000329_bf {
    public static class _battlezone_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6609, 6610}, arg2: false);
                context.SetMesh(arg1: new[] {1531, 1532, 1533, 1534, 1535, 1536, 1537, 1538, 1539, 1540}, arg2: true, arg3: 0, arg4: 1000, arg5: 0f);
                context.SetMesh(arg1: new[] {19994}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {704})) {
                    return new State애플몽키소환(context);
                }

                if (context.MonsterDead(arg1: new[] {1109, 1110})) {
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
                context.CreateMonster(arg1: new[] {704}, arg2: false);
                context.SetEffect(arg1: new[] {6609, 6610}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1109, 1110})) {
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
                context.SetTimer(id: "3", arg2: 3, arg4: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 102, textId: 40011);
                context.SetMesh(arg1: new[] {19994}, arg2: false);
                context.SetMesh(arg1: new[] {1531, 1532, 1533, 1534, 1535, 1536, 1537, 1538, 1539, 1540}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
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