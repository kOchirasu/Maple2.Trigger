namespace Maple2.Trigger._99999841 {
    public static class _debuffactive {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 801) == true) {
                    return new State이동속도감소(context);
                }

                if (context.GetDungeonVariable(id: 802) == true) {
                    return new State공격력감소(context);
                }

                if (context.GetDungeonVariable(id: 803) == true) {
                    return new State체력감소(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동속도감소 : TriggerState {
            internal State이동속도감소(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 801, value: false);
                context.SetEventUI(arg1: 1, arg2: "이동속도 감소 디Buff에 걸립니다.", arg3: 5000);
                context.AddBuff(arg1: new[] {9001}, arg2: 70002581, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                // return new StateEnd(context);
                    return null;
            }

            public override void OnExit() { }
        }

        private class State공격력감소 : TriggerState {
            internal State공격력감소(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 802, value: false);
                context.SetEventUI(arg1: 1, arg2: "공격력 감소 디Buff에 걸립니다.", arg3: 5000);
                context.AddBuff(arg1: new[] {9001}, arg2: 70002591, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                // return new StateEnd(context);
                    return null;
            }

            public override void OnExit() { }
        }

        private class State체력감소 : TriggerState {
            internal State체력감소(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 803, value: false);
                context.SetEventUI(arg1: 1, arg2: "체력 감소 디Buff에 걸립니다.", arg3: 5000);
                context.AddBuff(arg1: new[] {9001}, arg2: 70002601, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                // return new StateEnd(context);
                    return null;
            }

            public override void OnExit() { }
        }
    }
}