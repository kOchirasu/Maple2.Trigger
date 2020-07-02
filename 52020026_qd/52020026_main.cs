namespace Maple2.Trigger._52020026_qd {
    public static class _52020026_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018}, arg2: false);
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028, 9029, 9030, 9031, 9032}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001320, 10001321, 10001322, 10001323, 10001324, 10001325}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State1층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1층 : TriggerState {
            internal State1층(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State1층레버활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1층레버활성 : TriggerState {
            internal State1층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "레버를 작동시켜 계단을 완성하세요.", arg3: 5000);
                context.SetInteractObject(arg1: new[] {10001320}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001320}, arg2: 0)) {
                    return new State2층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2층 : TriggerState {
            internal State2층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002, 1003}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    return new State2층레버활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2층레버활성 : TriggerState {
            internal State2층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001321}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001321}, arg2: 0)) {
                    return new State3층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3층 : TriggerState {
            internal State3층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 104}, arg2: false);
                context.SetMesh(arg1: new[] {1004, 1005, 1006}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {103, 104})) {
                    return new State3층레버활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3층레버활성 : TriggerState {
            internal State3층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001322}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001322}, arg2: 0)) {
                    return new State4층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4층 : TriggerState {
            internal State4층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105, 106}, arg2: false);
                context.SetMesh(arg1: new[] {1007, 1008, 1009}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {105, 106})) {
                    return new State4층레버활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4층레버활성 : TriggerState {
            internal State4층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001323}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001323}, arg2: 0)) {
                    return new State5층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5층 : TriggerState {
            internal State5층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.SetMesh(arg1: new[] {1010, 1011, 1012}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {906})) {
                    return new State5층_벽부수기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5층_벽부수기 : TriggerState {
            internal State5층_벽부수기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016}, arg2: false);
                context.CreateMonster(arg1: new[] {108}, arg2: true);
                context.SetSkill(arg1: new[] {1}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {107, 108})) {
                    return new State5층레버활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5층레버활성 : TriggerState {
            internal State5층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001324}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001324}, arg2: 0)) {
                    return new State6층(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6층 : TriggerState {
            internal State6층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109, 110}, arg2: false);
                context.SetMesh(arg1: new[] {1013, 1014, 1015}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {907})) {
                    return new State6층_벽부수기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6층_벽부수기 : TriggerState {
            internal State6층_벽부수기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028, 9029, 9030, 9031, 9032}, arg2: false);
                context.CreateMonster(arg1: new[] {111}, arg2: true);
                context.SetSkill(arg1: new[] {2}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {109, 110, 111})) {
                    return new State6층레버활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6층레버활성 : TriggerState {
            internal State6층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001325}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001325}, arg2: 0)) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1016, 1017, 1018}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
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