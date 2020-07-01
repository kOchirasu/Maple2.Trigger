using System;

namespace Maple2.Trigger._02000109_in {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: true);
                context.SetMesh(arg1: new int[] {4011}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101, 102});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트조건체크 : TriggerState {
            internal State퀘스트조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001608},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001608},
                    arg3: new byte[] {2})) {
                    context.State = new State일기장스폰_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001608},
                    arg3: new byte[] {1})) {
                    context.State = new State일기장스폰_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {3})) {
                    context.State = new State일기장스폰_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {2})) {
                    context.State = new State일기장스폰_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {1})) {
                    context.State = new State벽삭제(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001606},
                    arg3: new byte[] {3})) {
                    context.State = new Statenpc스폰_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001606},
                    arg3: new byte[] {2})) {
                    context.State = new Statenpc스폰_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001606},
                    arg3: new byte[] {1})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트진행체크 : TriggerState {
            internal State퀘스트진행체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001608},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001608},
                    arg3: new byte[] {2})) {
                    // context.State = new State일기장스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001608},
                    arg3: new byte[] {1})) {
                    // context.State = new State일기장스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {3})) {
                    // context.State = new State일기장스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {2})) {
                    context.State = new State일기장스폰_대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {1})) {
                    context.State = new State벽삭제(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001606},
                    arg3: new byte[] {3})) {
                    context.State = new Statenpc스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001606},
                    arg3: new byte[] {2})) {
                    context.State = new Statenpc스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001606},
                    arg3: new byte[] {1})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc스폰_대기 : TriggerState {
            internal Statenpc스폰_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {1})) {
                    context.State = new State벽삭제(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트진행체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc스폰 : TriggerState {
            internal Statenpc스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {1})) {
                    context.State = new State벽삭제(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트진행체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽삭제 : TriggerState {
            internal State벽삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {2})) {
                    context.State = new State일기장스폰_대기(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트진행체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일기장스폰_대기 : TriggerState {
            internal State일기장스폰_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetMesh(arg1: new int[] {4011}, arg2: true);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {3})) {
                    context.State = new State일기장스폰01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일기장스폰01 : TriggerState {
            internal State일기장스폰01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4011}, arg2: true);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {2})) {
                    context.State = new State일기장스폰02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001606},
                    arg3: new byte[] {3})) {
                    context.State = new State일기장없어짐(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {3})) {
                    context.State = new State일기장스폰02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일기장스폰02 : TriggerState {
            internal State일기장스폰02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4011}, arg2: true);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {3})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {2})) {
                    context.State = new State일기장스폰01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001606},
                    arg3: new byte[] {3})) {
                    context.State = new State일기장없어짐(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {3})) {
                    context.State = new State일기장스폰01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State일기장없어짐 : TriggerState {
            internal State일기장없어짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
                context.SetMesh(arg1: new int[] {4011}, arg2: false);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {2})) {
                    context.State = new State일기장스폰_대기(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001607},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트진행체크(context);
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