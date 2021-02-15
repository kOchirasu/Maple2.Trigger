namespace Maple2.Trigger._02000491_bf {
    public static class _main2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3107, 3108, 3109, 3110, 3111, 3112, 3115, 3116}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000989, 10000990, 10000991, 10000992, 10000993, 10000994, 10000997, 10000998}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1002})) {
                    return new State전투01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {21101, 21102, 21103, 21104, 21105, 21106, 21107, 21201, 21202, 21203, 21204, 21205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {21101, 21102, 21103, 21104, 21105, 21106, 21107, 21201, 21202, 21203, 21204, 21205})) {
                    return new State전투02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투02 : TriggerState {
            internal State전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3107, 3108}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000989, 10000990}, arg2: 1);
                context.CreateMonster(arg1: new[] {22101, 22102, 22103, 22104, 22105, 22106, 22107, 22201, 22202, 22203, 22204, 22205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {22101, 22102, 22103, 22104, 22105, 22106, 22107, 22201, 22202, 22203, 22204, 22205})) {
                    return new State전투03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투03 : TriggerState {
            internal State전투03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3109, 3110}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000991, 10000992}, arg2: 1);
                context.CreateMonster(arg1: new[] {23102, 23103, 23104, 23105, 23106, 23107, 23108, 23201, 23202, 23203, 23204, 23205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {23102, 23103, 23104, 23105, 23106, 23107, 23108, 23201, 23202, 23203, 23204, 23205})) {
                    context.SetMesh(arg1: new[] {3111, 3112}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(arg1: new[] {10000993, 10000994}, arg2: 1);
                    context.SetUserValue(triggerId: 9999901, key: "main", value: 1);
                    return new State합류Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State합류Wait : TriggerState {
            internal State합류Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "main2") == 1) {
                    return new State전투04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투04 : TriggerState {
            internal State전투04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {51101, 51102, 51103, 51104, 51105, 51106, 51107, 51108, 51201, 51202, 51203, 51204, 51205, 51206}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {51101, 51102, 51103, 51104, 51105, 51106, 51107, 51108, 51201, 51202, 51203, 51204, 51205, 51206})) {
                    context.SetMesh(arg1: new[] {3115, 3116}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(arg1: new[] {10000997, 10000998}, arg2: 1);
                    return new StateEnd(context);
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