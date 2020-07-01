namespace Maple2.Trigger._02020025_bf {
    public static class _dungeonmission {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    context.State = new State던전미션체크대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션체크대기 : TriggerState {
            internal State던전미션체크대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 904, arg2: new[] {201})) {
                    context.State = new State체력90이하체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State체력90이하체크 : TriggerState {
            internal State체력90이하체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.90f) {
                    context.State = new State지하1층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하1층 : TriggerState {
            internal State지하1층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24092001);
            }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.70f) {
                    context.State = new State지하2층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하2층 : TriggerState {
            internal State지하2층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24092002);
            }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.55f) {
                    context.State = new State지하3층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하3층 : TriggerState {
            internal State지하3층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24092003);
            }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 201) <= 0.40f) {
                    context.State = new State지하4층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하4층 : TriggerState {
            internal State지하4층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 24092004);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}