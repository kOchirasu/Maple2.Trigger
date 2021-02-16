namespace Maple2.Trigger._02000336_bf {
    public static class _boss {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90, 92, 93});
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(arg1: new[] {7001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7015}, arg2: true);
                context.CreateMonster(arg1: new[] {101});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State조직원Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조직원Spawn : TriggerState {
            internal State조직원Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetMesh(arg1: new[] {8041, 8042, 8043, 8044}, arg2: false, arg4: 0, arg5: 10f);
                context.SetSkill(arg1: new[] {5801}, arg2: true);
                context.CreateMonster(arg1: new[] {181, 182, 183});
                context.SetTimer(id: "2", arg2: 2, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State웨이홍_Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웨이홍_Script01 : TriggerState {
            internal State웨이홍_Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91});
                context.DestroyMonster(arg1: new[] {90});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003124, script: "$02000336_BF__BOSS__0$", arg4: 3);
                context.SetSkip(state: new State웨이홍_Script02(context));
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State웨이홍_Script02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State웨이홍_Script02 : TriggerState {
            internal State웨이홍_Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003124, script: "$02000336_BF__BOSS__1$", arg4: 3);
                context.SetSkip(state: new StateEnd(context));
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 112, textId: 40009);
                context.CameraSelect(arg1: 8001, arg2: false);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}