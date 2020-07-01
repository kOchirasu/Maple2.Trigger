namespace Maple2.Trigger._52000020_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {60001022}, arg3: new byte[] {1})) {
                    context.State = new Statecamera_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera_01 : TriggerState {
            internal Statecamera_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statemonster_spawn_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemonster_spawn_01 : TriggerState {
            internal Statemonster_spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {111, 112, 113, 114}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$52000020_QD__MAIN__2$", arg4: 5);
                context.SetConversation(arg1: 1, arg2: 112, arg3: "$52000020_QD__MAIN__3$", arg4: 5);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statebattle_01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114})) {
                    context.State = new Statecamera_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class Statebattle_01 : TriggerState {
            internal Statebattle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114})) {
                    context.State = new Statecamera_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class Statecamera_02 : TriggerState {
            internal Statecamera_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statemonster_spawn_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemonster_spawn_02 : TriggerState {
            internal Statemonster_spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 125, 126}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 121, arg3: "$52000020_QD__MAIN__4$", arg4: 5);
                context.SetConversation(arg1: 1, arg2: 124, arg3: "$52000020_QD__MAIN__5$", arg4: 5);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statebattle_02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {121, 122, 123, 124, 125, 126})) {
                    context.State = new Statecamera_03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class Statebattle_02 : TriggerState {
            internal Statebattle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {121, 122, 123, 124, 125, 126})) {
                    context.State = new Statecamera_03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class Statecamera_03 : TriggerState {
            internal Statecamera_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 1);
                context.CameraSelectPath(arg1: new[] {8005, 8006}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statemonster_spawn_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemonster_spawn_03 : TriggerState {
            internal Statemonster_spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {131, 132, 133, 134, 135, 136}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statebattle_03(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {131, 132, 133, 134, 135, 136})) {
                    context.State = new Statecomplete(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetConversation(arg1: 1, arg2: 131, arg3: "$52000020_QD__MAIN__1$", arg4: 5);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class Statebattle_03 : TriggerState {
            internal Statebattle_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {131, 132, 133, 134, 135, 136})) {
                    context.State = new Statecomplete(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class Statecomplete : TriggerState {
            internal Statecomplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}