namespace Maple2.Trigger._52000020_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {60001022}, arg3: new byte[] {1})) {
                    return new StateCamera_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_01 : TriggerState {
            internal StateCamera_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateMonster_spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_spawn_01 : TriggerState {
            internal StateMonster_spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {111, 112, 113, 114}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$52000020_QD__MAIN__2$", arg4: 5);
                context.SetConversation(arg1: 1, arg2: 112, arg3: "$52000020_QD__MAIN__3$", arg4: 5);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBattle_01(context);
                }

                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114})) {
                    return new StateCamera_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
            }
        }

        private class StateBattle_01 : TriggerState {
            internal StateBattle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114})) {
                    return new StateCamera_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class StateCamera_02 : TriggerState {
            internal StateCamera_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateMonster_spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_spawn_02 : TriggerState {
            internal StateMonster_spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 125, 126}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 121, arg3: "$52000020_QD__MAIN__4$", arg4: 5);
                context.SetConversation(arg1: 1, arg2: 124, arg3: "$52000020_QD__MAIN__5$", arg4: 5);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBattle_02(context);
                }

                if (context.MonsterDead(arg1: new[] {121, 122, 123, 124, 125, 126})) {
                    return new StateCamera_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
            }
        }

        private class StateBattle_02 : TriggerState {
            internal StateBattle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {121, 122, 123, 124, 125, 126})) {
                    return new StateCamera_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class StateCamera_03 : TriggerState {
            internal StateCamera_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
                context.CameraSelectPath(arg1: new[] {8005, 8006}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateMonster_spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_spawn_03 : TriggerState {
            internal StateMonster_spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {131, 132, 133, 134, 135, 136}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBattle_03(context);
                }

                if (context.MonsterDead(arg1: new[] {131, 132, 133, 134, 135, 136})) {
                    return new StateComplete(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetConversation(arg1: 1, arg2: 131, arg3: "$52000020_QD__MAIN__1$", arg4: 5);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetCinematicUI(arg1: 7);
            }
        }

        private class StateBattle_03 : TriggerState {
            internal StateBattle_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {131, 132, 133, 134, 135, 136})) {
                    return new StateComplete(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class StateComplete : TriggerState {
            internal StateComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}