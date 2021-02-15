namespace Maple2.Trigger._02020025_bf {
    public static class _dungeonmission {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new State던전미션체크Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션체크Wait : TriggerState {
            internal State던전미션체크Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 904, arg2: new[] {201})) {
                    return new State체력90이하체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체력90이하체크 : TriggerState {
            internal State체력90이하체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.90f) {
                    return new State지하1층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하1층 : TriggerState {
            internal State지하1층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24092001);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.70f) {
                    return new State지하2층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하2층 : TriggerState {
            internal State지하2층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24092002);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.55f) {
                    return new State지하3층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하3층 : TriggerState {
            internal State지하3층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24092003);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.40f) {
                    return new State지하4층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하4층 : TriggerState {
            internal State지하4층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24092004);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
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