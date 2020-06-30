using System;

namespace Maple2.Trigger._52000092_qd {
    public static class _52000092_trigger {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -39.0f);
                context.CreateMonster(arg1: new int[] {800}, arg2: false);
                context.SetMesh(arg1: new int[] {900}, arg2: false);
                context.SetEffect(arg1: new int[] {901}, arg2: false);
                context.SetEffect(arg1: new int[] {902}, arg2: false);
                context.SetEffect(arg1: new int[] {903}, arg2: false);
                context.SetEffect(arg1: new int[] {904}, arg2: false);
                context.SetEffect(arg1: new int[] {905}, arg2: false);
                context.SetEffect(arg1: new int[] {906}, arg2: false);
                context.SetEffect(arg1: new int[] {907}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State중력감지메시지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State50100520퀘스트체크 : TriggerState {
            internal State50100520퀘스트체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {3})) {
                    context.State = new State52000091이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {2})) {
                    context.State = new State52000091이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {1})) {
                    context.State = new State52000091이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중력감지메시지 : TriggerState {
            internal State중력감지메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25200921, textID: 25200921, duration: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100510},
                    arg3: new byte[] {1})) {
                    context.State = new State20002276진행중일때(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002276},
                    arg3: new byte[] {1})) {
                    context.State = new State20002276진행중일때(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002276진행중일때 : TriggerState {
            internal State20002276진행중일때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {900}, arg2: true, arg3: 0, arg4: 0, arg5: 5000f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100510},
                    arg3: new byte[] {2})) {
                    context.State = new State20002276완료가능할때(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002276},
                    arg3: new byte[] {2})) {
                    context.State = new State20002276완료가능할때(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002276완료가능할때 : TriggerState {
            internal State20002276완료가능할때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {900}, arg2: false, arg3: 0, arg4: 0, arg5: 100f);
                context.SetEffect(arg1: new int[] {901}, arg2: true);
                context.SetEffect(arg1: new int[] {902}, arg2: true);
                context.SetEffect(arg1: new int[] {903}, arg2: true);
                context.SetEffect(arg1: new int[] {904}, arg2: true);
                context.SetEffect(arg1: new int[] {905}, arg2: true);
                context.SetEffect(arg1: new int[] {906}, arg2: true);
                context.SetEffect(arg1: new int[] {907}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {50100520},
                    arg3: new byte[] {2})) {
                    context.State = new State50100520완료시01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002277},
                    arg3: new byte[] {2})) {
                    // context.State = new State20002277완료시01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State50100520완료시01 : TriggerState {
            internal State50100520완료시01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    // context.State = new State50100520완료시02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002277완료시02 : TriggerState {
            internal State20002277완료시02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002277완료시03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002277완료시03 : TriggerState {
            internal State20002277완료시03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 800, arg2: "MS2PatrolData_ordeMove");
                context.CameraSelectPath(arg1: new int[] {2000, 2001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002277완료시04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002277완료시04 : TriggerState {
            internal State20002277완료시04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2002, 2003, 2004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002277완료시05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002277완료시05 : TriggerState {
            internal State20002277완료시05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2005, 2006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002277완료시06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002277완료시06 : TriggerState {
            internal State20002277완료시06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2007, 2008}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 800, arg2: "IceSphere_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002277완료시07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002277완료시07 : TriggerState {
            internal State20002277완료시07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2009, 2010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State20002277완료시08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002277완료시08 : TriggerState {
            internal State20002277완료시08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State20002277완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002277완료 : TriggerState {
            internal State20002277완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 52000092, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State52000091이동 : TriggerState {
            internal State52000091이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 52000091, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}