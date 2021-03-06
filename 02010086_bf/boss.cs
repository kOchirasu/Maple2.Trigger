namespace Maple2.Trigger._02010086_bf {
    public static class _boss {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 799) == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {995, 999, 998});
                context.CreateMonster(arg1: new[] {199}, arg2: true);
                context.SetTimer(id: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State소환_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_01 : TriggerState {
            internal State소환_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {181, 188}, arg2: true);
                context.SetTimer(id: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State소환_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_02 : TriggerState {
            internal State소환_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {182, 187}, arg2: true);
                context.SetTimer(id: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State소환_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_03 : TriggerState {
            internal State소환_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {183, 186}, arg2: true);
                context.SetTimer(id: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State소환_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_04 : TriggerState {
            internal State소환_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {184, 185}, arg2: true);
                context.SetTimer(id: "20", arg2: 20);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                if (context.TimeExpired(arg1: "20")) {
                    return new State소환_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환_05 : TriggerState {
            internal State소환_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {996}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StatePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOpen : TriggerState {
            internal StatePortalOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {181, 182, 183, 184, 185, 186, 187, 188, 997, 996, 995});
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 112, textId: 40009);
                context.SetMesh(arg1: new[] {1098}, arg2: false, arg4: 0, arg5: 10f);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 112);
            }
        }
    }
}