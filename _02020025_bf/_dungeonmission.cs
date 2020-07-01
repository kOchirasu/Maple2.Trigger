using System;

namespace Maple2.Trigger._02020025_bf {
    public static class _dungeonmission {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {901})) {
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
                if (context.NpcDetected(arg1: 904, arg2: new int[] {201})) {
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
                if (context.CheckNpcHp(compare: "lowerEqual", value: 90, spawnPointId: 201, isRelative: "true")) {
                    context.State = new State지하1층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하1층 : TriggerState {
            internal State지하1층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 24092001);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 70, spawnPointId: 201, isRelative: "true")) {
                    context.State = new State지하2층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하2층 : TriggerState {
            internal State지하2층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 24092002);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 55, spawnPointId: 201, isRelative: "true")) {
                    context.State = new State지하3층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하3층 : TriggerState {
            internal State지하3층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 24092003);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 40, spawnPointId: 201, isRelative: "true")) {
                    context.State = new State지하4층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하4층 : TriggerState {
            internal State지하4층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 24092004);
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