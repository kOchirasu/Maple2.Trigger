namespace Maple2.Trigger._80000014_bonus {
    public static class _spawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001326, 10001327, 10001328, 10001329, 10001330, 10001331, 10001332, 10001333}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateRandomA(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomA : TriggerState {
            internal StateRandomA(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001326}, arg2: 1);
                    return new StateRandomB(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1501}, arg2: false);
                    return new StateRandomB(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomB : TriggerState {
            internal StateRandomB(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001327}, arg2: 1);
                    return new StateRandomC(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1502}, arg2: false);
                    return new StateRandomC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomC : TriggerState {
            internal StateRandomC(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001328}, arg2: 1);
                    return new StateRandomD(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1503}, arg2: false);
                    return new StateRandomD(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomD : TriggerState {
            internal StateRandomD(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001329}, arg2: 1);
                    return new StateRandomE(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1504}, arg2: false);
                    return new StateRandomE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomE : TriggerState {
            internal StateRandomE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001330}, arg2: 1);
                    return new StateRandomF(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1505}, arg2: false);
                    return new StateRandomF(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomF : TriggerState {
            internal StateRandomF(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001331}, arg2: 1);
                    return new StateRandomG(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1506}, arg2: false);
                    return new StateRandomG(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomG : TriggerState {
            internal StateRandomG(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001332}, arg2: 1);
                    return new StateRandomH(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.CreateMonster(arg1: new[] {1507}, arg2: false);
                    return new StateRandomH(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomH : TriggerState {
            internal StateRandomH(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001333}, arg2: 1);
                    return new State스폰1(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.SetInteractObject(arg1: new[] {10001333}, arg2: 1);
                    return new State스폰1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰1 : TriggerState {
            internal State스폰1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {112})) {
                    return new State스폰2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰2 : TriggerState {
            internal State스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {113})) {
                    return new State스폰3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰3 : TriggerState {
            internal State스폰3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {114})) {
                    return new State스폰4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰4 : TriggerState {
            internal State스폰4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1053, 1054, 1055, 1056, 1057, 1058, 1059}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {115})) {
                    return new State스폰5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰5 : TriggerState {
            internal State스폰5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1060, 1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {116})) {
                    return new State스폰6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰6 : TriggerState {
            internal State스폰6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1074, 1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083}, isAutoTargeting: false, score: 100);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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