namespace Maple2.Trigger._02000352_bf {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{900001, 900002, 900003, 900004, 900005}, visible: false);
                context.SetInteractObject(interactIds: new []{10000822}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new State관문01_시작(context);
                }

                if (context.GetUserCount(boxId: 703) == 1) {
                    return new State관문_03_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문01_시작 : TriggerState {
            internal State관문01_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{11, 12, 13, 14, 15, 16, 17}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{11, 12, 13, 14, 15, 16, 17})) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000822}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new State관문_02_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_시작 : TriggerState {
            internal State관문_02_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{21, 22, 23, 24, 25, 26, 27, 28, 29}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{21, 22, 23, 24, 25, 26, 27, 28, 29})) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 111, textId: 20000080);
                context.SetInteractObject(interactIds: new []{10000823, 10000824}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new State관문_03_시작(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
            }
        }

        private class State관문_03_시작 : TriggerState {
            internal State관문_03_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{31, 32, 33}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{31, 32})) {
                    return new State관문_03_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6004}, visible: false, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{6007}, visible: true, arg4: 0, arg5: 10f);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 112, textId: 40009);
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
