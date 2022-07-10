namespace Maple2.Trigger._99999840 {
    public static class _debuffmob {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 801, value: false);
                context.SetDungeonVariable(varId: 802, value: false);
                context.SetDungeonVariable(varId: 803, value: false);
            }

            public override TriggerState? Execute() {
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
                context.SetTimer(timerId: "2", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "2")) {
                    return new StateRandom확률(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom확률 : TriggerState {
            internal StateRandom확률(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: @"디버프 몬스터가 생성되었습니다.\n몬스터를 처치하면 상대팀에 디버프를 겁니다.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    return new StateA지역(context);
                }

                if (context.RandomCondition(rate: 34f)) {
                    return new StateB지역(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    return new StateC지역(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA지역 : TriggerState {
            internal StateA지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{801}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{801})) {
                    context.SetEventUI(arg1: 1, script: "상대팀에 이동속도 감소 디Buff를 겁니다.", duration: 5000);
                    context.SetDungeonVariable(varId: 801, value: true);
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB지역 : TriggerState {
            internal StateB지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{802}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{802})) {
                    context.SetEventUI(arg1: 1, script: "상대팀에 공격력 감소 디Buff를 겁니다.", duration: 5000);
                    context.SetDungeonVariable(varId: 802, value: true);
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC지역 : TriggerState {
            internal StateC지역(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{803}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{803})) {
                    context.SetEventUI(arg1: 1, script: "상대팀에 체력 감소 디Buff를 겁니다.", duration: 5000);
                    context.SetDungeonVariable(varId: 803, value: true);
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 3) == true) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
