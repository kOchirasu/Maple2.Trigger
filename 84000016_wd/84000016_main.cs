using System.Numerics;

namespace Maple2.Trigger._84000016_wd {
    public static class _84000016_main {
        public class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Weddingceremonystarts", value: 0);
                context.SetPortal(arg1: 99, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return new State결혼식StartCinematic요청대기(context);
            }

            public override void OnExit() { }
        }

        private class State결혼식StartCinematic요청대기 : TriggerState {
            internal State결혼식StartCinematic요청대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: false);
                context.HideGuideSummary(entityId: 28400140);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Weddingceremonystarts") == 1) {
                    context.SetUserValue(key: "Weddingceremonystarts", value: 0);
                    context.LockMyPc(isLock: true);
                    return new StateStart알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart알림 : TriggerState {
            internal StateStart알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400134, textId: 28400134);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400134);
            }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000016, arg2: new byte[] {22, 23}, arg3: 701);
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000016, arg2: new byte[] {22, 23}, arg3: 703);
                context.WeddingMoveUser(entryType: "Groom", arg1: 84000016, arg2: new byte[] {11}, arg3: 702);
                context.WeddingMoveUser(entryType: "Bride", arg1: 84000016, arg2: new byte[] {12}, arg3: 702);
                context.SetPortal(arg1: 99, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State주례줌인01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State주례줌인01 : TriggerState {
            internal State주례줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {8002, 8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State주례줌인02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State주례줌인02 : TriggerState {
            internal State주례줌인02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11004711, msg: "$84000016_WD__84000016_MAIN__0$", duration: 3500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State시선돌리기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시선돌리기01 : TriggerState {
            internal State시선돌리기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세레나데(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세레나데 : TriggerState {
            internal State세레나데(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateUI테스트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUI테스트 : TriggerState {
            internal StateUI테스트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State입장준비01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장준비01 : TriggerState {
            internal State입장준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State입장준비02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장준비02 : TriggerState {
            internal State입장준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingSetUserEmotion(entryType: "Bride", id: 6);
                context.WeddingSetUserEmotion(entryType: "Groom", id: 6);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장01 : TriggerState {
            internal State입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004, 8005, 8011}, arg2: false);
                context.WeddingUserToPatrol(patrolName: "MS2PatrolData_2001", entryType: "Groom", patrolIndex: 1);
                context.WeddingUserToPatrol(patrolName: "MS2PatrolData_2002", entryType: "Bride", patrolIndex: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동01 : TriggerState {
            internal StateCamera이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    return new StateCamera이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동02 : TriggerState {
            internal StateCamera이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State주례사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State주례사 : TriggerState {
            internal State주례사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 3);
                context.WeddingSetUserRotation(entryType: "Groom", rotation: new Vector3(0f, 0f, 0f), immediate: true);
                context.WeddingSetUserRotation(entryType: "Bride", rotation: new Vector3(0f, 0f, 0f), immediate: true);
                context.AddCinematicTalk(npcId: 11004711, msg: "$84000016_WD__84000016_MAIN__1$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State성혼타이핑결과확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성혼타이핑결과확인 : TriggerState {
            internal State성혼타이핑결과확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMutualAgree(agreeType: "partnerName");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.WeddingMutualCancel(agreeType: "partnerName");
                    return new State미입력으로중단01(context);
                }

                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: false)) {
                    context.WeddingMutualCancel(agreeType: "partnerName");
                    return new State탈주로중단(context);
                }

                if (context.WeddingMutualAgreeResult(agreeType: "partnerName", success: false)) {
                    return new State탈주로중단(context);
                }

                if (context.WeddingMutualAgreeResult(agreeType: "partnerName", success: true)) {
                    return new State성혼발표(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈주로중단 : TriggerState {
            internal State탈주로중단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004711, msg: "$84000016_WD__84000016_MAIN__2$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State탈주로중단선언(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈주로중단선언 : TriggerState {
            internal State탈주로중단선언(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004711, msg: "$84000016_WD__84000016_MAIN__3$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State탈주로중단선언리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미입력으로중단01 : TriggerState {
            internal State미입력으로중단01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004711, msg: "$84000016_WD__84000016_MAIN__4$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미입력으로중단선언(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미입력으로중단선언 : TriggerState {
            internal State미입력으로중단선언(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004711, msg: "$84000016_WD__84000016_MAIN__5$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State탈주로중단선언리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈주로중단선언리셋 : TriggerState {
            internal State탈주로중단선언리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4002, key: "Weddingceremonyfail", value: 1);
                context.SetUserValue(triggerId: 4000, key: "Weddingceremonyfail", value: 1);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                return new State결혼식StartCinematic요청대기(context);
            }

            public override void OnExit() { }
        }

        private class State성혼발표 : TriggerState {
            internal State성혼발표(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004711, msg: "$84000016_WD__84000016_MAIN__6$", duration: 2500);
                context.WeddingVowComplete();
                context.SetUserValue(triggerId: 4002, key: "WeddingFinished", value: 1);
                context.WeddingSetUserLookAt(entryType: "Bride", lookAtEntryType: "Groom", immediate: true);
                context.WeddingSetUserLookAt(entryType: "Groom", lookAtEntryType: "Bride", immediate: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State환호성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State환호성 : TriggerState {
            internal State환호성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.WeddingSetUserEmotion(entryType: "Bride", id: 4);
                context.WeddingSetUserEmotion(entryType: "Groom", id: 4);
                context.PlaySystemSoundInBox(arg2: "System_WeddingAudience_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State뒷풀이01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷풀이01 : TriggerState {
            internal State뒷풀이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보상과결혼상태마지막체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보상과결혼상태마지막체크 : TriggerState {
            internal State보상과결혼상태마지막체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: false);
            }

            public override TriggerState Execute() {
                if (context.WeddingHallState(hallState: "weddingComplete", success: true)) {
                    return new State뒷풀이02(context);
                }

                return new State보상결혼상태체크실패(context);
            }

            public override void OnExit() { }
        }

        private class State보상결혼상태체크실패 : TriggerState {
            internal State보상결혼상태체크실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4002, key: "Weddingceremonyfail", value: 1);
                context.SetUserValue(triggerId: 4000, key: "Weddingceremonyfail", value: 1);
                context.ShowGuideSummary(entityId: 28400140);
            }

            public override TriggerState Execute() {
                return new State결혼식StartCinematic요청대기(context);
            }

            public override void OnExit() { }
        }

        private class State뒷풀이02 : TriggerState {
            internal State뒷풀이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400135, textId: 28400135);
                context.SetPortal(arg1: 99, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State뒷풀이03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400135);
            }
        }

        private class State뒷풀이03 : TriggerState {
            internal State뒷풀이03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400136, textId: 28400136);
                context.SetUserValue(key: "EndWedding", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "EndWedding") == 1) {
                    return new State결혼종료확인(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400136);
            }
        }

        private class State결혼종료확인 : TriggerState {
            internal State결혼종료확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMutualAgree(agreeType: "endActing");
            }

            public override TriggerState Execute() {
                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: false)) {
                    return new StateEnd알림(context);
                }

                if (context.WeddingMutualAgreeResult(agreeType: "endActing", success: true)) {
                    return new StateEnd알림(context);
                }

                if (context.WeddingMutualAgreeResult(agreeType: "endActing", success: false)) {
                    return new State뒷풀이03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd알림 : TriggerState {
            internal StateEnd알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400137, textId: 28400137);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new State끄읏(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400137);
            }
        }

        private class State끄읏 : TriggerState {
            internal State끄읏(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}