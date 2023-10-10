namespace Maple2.Trigger._52000092_qd {
    public static class _52000092_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetGravity(gravity: -39.0f);
                context.CreateMonster(spawnIds: new []{800}, arg2: false);
                context.SetMesh(triggerIds: new []{900}, visible: false);
                context.SetEffect(triggerIds: new []{901, 902, 903, 904, 905, 906, 907}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State중력감지메시지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50100520Quest체크 : TriggerState {
            internal State50100520Quest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{3})) {
                    return new State52000091이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{2})) {
                    return new State52000091이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{1})) {
                    return new State52000091이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중력감지메시지 : TriggerState {
            internal State중력감지메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200921, textId: 25200921, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100510}, questStates: new byte[]{1})) {
                    return new State20002276진행중일때(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002276}, questStates: new byte[]{1})) {
                    return new State20002276진행중일때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002276진행중일때 : TriggerState {
            internal State20002276진행중일때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{900}, visible: true, arg3: 0, arg4: 0, arg5: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100510}, questStates: new byte[]{2})) {
                    return new State20002276완료가능할때(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002276}, questStates: new byte[]{2})) {
                    return new State20002276완료가능할때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002276완료가능할때 : TriggerState {
            internal State20002276완료가능할때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{900}, visible: false, arg3: 0, arg4: 0, arg5: 100f);
                context.SetEffect(triggerIds: new []{901, 902, 903, 904, 905, 906, 907}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{50100520}, questStates: new byte[]{2})) {
                    return new State50100520완료시01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002277}, questStates: new byte[]{2})) {
                    // return new State20002277완료시01(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50100520완료시01 : TriggerState {
            internal State50100520완료시01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    // return new State50100520완료시02(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료시02 : TriggerState {
            internal State20002277완료시02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002277완료시03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료시03 : TriggerState {
            internal State20002277완료시03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 800, patrolName: "MS2PatrolData_ordeMove");
                context.CameraSelectPath(pathIds: new []{2000, 2001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002277완료시04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료시04 : TriggerState {
            internal State20002277완료시04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2002, 2003, 2004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002277완료시05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료시05 : TriggerState {
            internal State20002277완료시05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2005, 2006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002277완료시06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료시06 : TriggerState {
            internal State20002277완료시06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2007, 2008}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 800, sequenceName: "IceSphere_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002277완료시07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료시07 : TriggerState {
            internal State20002277완료시07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2009, 2010}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State20002277완료시08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료시08 : TriggerState {
            internal State20002277완료시08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State20002277완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002277완료 : TriggerState {
            internal State20002277완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 52000092, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State52000091이동 : TriggerState {
            internal State52000091이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 52000091, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
