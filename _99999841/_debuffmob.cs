namespace Maple2.Trigger._99999841 {
    public static class _debuffmob {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 811, value: false);
                context.SetDungeonVariable(varId: 812, value: false);
                context.SetDungeonVariable(varId: 813, value: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "Start") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    return new StateRandom확률(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom확률 : TriggerState {
            internal StateRandom확률(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"디버프 몬스터가 생성되었습니다.\n몬스터를 처치하면 상대팀에 디버프를 겁니다.", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateA지역(context);
                }

                if (context.RandomCondition(arg1: 34f)) {
                    return new StateB지역(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateC지역(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역 : TriggerState {
            internal StateA지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {801}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {801})) {
                    context.SetEventUI(arg1: 1, arg2: "상대팀에 이동속도 감소 디Buff를 겁니다.", arg3: 5000);
                    context.SetDungeonVariable(varId: 811, value: true);
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역 : TriggerState {
            internal StateB지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {802}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {802})) {
                    context.SetEventUI(arg1: 1, arg2: "상대팀에 공격력 감소 디Buff를 겁니다.", arg3: 5000);
                    context.SetDungeonVariable(varId: 812, value: true);
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역 : TriggerState {
            internal StateC지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {803}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {803})) {
                    context.SetEventUI(arg1: 1, arg2: "상대팀에 체력 감소 디Buff를 겁니다.", arg3: 5000);
                    context.SetDungeonVariable(varId: 813, value: true);
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.SetDungeonVariable(varId: 811, value: false);
                    context.SetDungeonVariable(varId: 812, value: false);
                    context.SetDungeonVariable(varId: 813, value: false);
                    return new StateWait(context);
                }

                return null;
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